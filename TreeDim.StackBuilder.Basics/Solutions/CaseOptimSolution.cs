﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using Sharp3D.Math.Core;
#endregion

namespace treeDiM.StackBuilder.Basics
{
    #region CaseOptimConstraintSet
    public class ParamSetPackOptim
    {
        #region Constructor
        public ParamSetPackOptim(
            int noBoxes
            , Vector3D caseLimitMin, Vector3D caseLimitMax
            , bool forceVerticalCaseOrientation
            , PackWrapper.WType wType
            , int[] noWalls
            , double wallThickness, double wallSurfaceMass
            , double trayHeight
            )
        {
            NoBoxes = noBoxes;
            NoWalls = noWalls;
            _wallThickness = wallThickness;
            _wallSurfaceMass = wallSurfaceMass;
            _caseLimitMin = caseLimitMin;
            _caseLimitMax = caseLimitMax;
            _forceVerticalCaseOrientation = forceVerticalCaseOrientation;
            _trayHeight = trayHeight;
            _wType = wType;
        }
        #endregion
        
        #region Public properties
        public int NoBoxes
        {
            get { return _noBoxes; }
            set { _noBoxes = value; }
        }
        public double WallThickness
        {
            get { return _wallThickness; }
            set { _wallThickness = value; }
        }
        public double WallSurfaceMass
        {
            get { return _wallSurfaceMass; }
            set { _wallSurfaceMass = value; }
        }
        public Vector3D CaseLimitMin
        {
            get { return _caseLimitMin; }
            set { _caseLimitMin = value; }
        }
        public Vector3D CaseLimitMax
        {
            get { return _caseLimitMax; }
            set { _caseLimitMax = value; }
        }
        public int[] NoWalls
        {
            get { return _noWalls; }
            set { for (int i = 0; i < 3; ++i)   _noWalls[i] = value[i]; }
        }
        public bool ForceVerticalcaseOrientation
        {
            get { return _forceVerticalCaseOrientation; }
            set { _forceVerticalCaseOrientation = value; }
        }
        public PackWrapper.WType WrapperType
        {
            get { return _wType; }
        }
        public double TrayHeight
        {
            get { return _trayHeight; } 
        }
        #endregion

        #region Public properties
        public int GetNoWalls(int iDir)
        {
            return _noWalls[iDir];
        }
        #endregion

        #region Data members
        private int _noBoxes;
        private bool _forceVerticalCaseOrientation;
        /// <summary>
        /// Case wall thickness
        /// </summary>
        private double _wallThickness;
        /// <summary>
        /// Case wall surface mass
        /// </summary>
        private double _wallSurfaceMass;
        /// <summary>
        /// Number of walls in each direction (used to compute outer case dimensions)
        /// </summary>
        private int[] _noWalls = new int[3];
        /// <summary>
        /// Optimal case min / max size limits
        /// </summary>
        private Vector3D _caseLimitMin, _caseLimitMax;

        private PackWrapper.WType _wType;
        private double _trayHeight;
        #endregion
    }
    #endregion

    #region CaseOptimArrangement

    #endregion

    #region CaseOptimDefinition
    public class CaseDefinition
    {
        #region Data members
        private PackArrangement _arrangement;
        private int _dim0, _dim1;
        #endregion

        #region Constructor
        /// <summary>
        /// Case definition constructor
        /// </summary>
        /// <param name="arrangement">Box arrangement</param>
        /// <param name="dim0">Dim 0 is 0, 1 or 2</param>
        /// <param name="dim1">Dim 1 is 0, 1 or 2</param>
        public CaseDefinition(PackArrangement arrangement, int dim0, int dim1)
        {
            _arrangement = arrangement;
            _dim0 = dim0;
            _dim1 = dim1;
        }
        #endregion

        #region Public properties
        public PackArrangement Arrangement
        {   get { return _arrangement; }    }
        public double BoxLength(PackableBrick packable)
        { return packable.Dim(_dim0); }
        public double BoxWidth(PackableBrick packable)
        { return packable.Dim(_dim1); }
        public double BoxHeight(PackableBrick packable)
        { return packable.Dim(Dim2); }
        public double Area(PackableBrick packable, ParamSetPackOptim constraintSet)
        {
            Vector3D outerDim = OuterDimensions(packable, constraintSet);
            return (constraintSet.NoWalls[0] * outerDim.Y * outerDim.Z
                + constraintSet.NoWalls[1] * outerDim.X * outerDim.Z
                + constraintSet.NoWalls[2] * outerDim.X * outerDim.Y) * UnitsManager.FactorSquareLengthToArea;
        }
        public double InnerVolume(PackableBrick packable)
        {
            Vector3D innerDim = InnerDimensions(packable);
            return innerDim.X * innerDim.Y * innerDim.Z;
        }
        public double OuterVolume(PackableBrick packable, ParamSetPackOptim constraintSet)
        {
            Vector3D outerDim = OuterDimensions(packable, constraintSet);
            return outerDim.X * outerDim.Y * outerDim.Z;
        }
        public double EmptyWeight(PackableBrick packable, ParamSetPackOptim constraintSet)
        { 
            return Area(packable, constraintSet) * constraintSet.WallSurfaceMass;
        }
        public double InnerWeight(PackableBrick packable)
        {
            return _arrangement.Number * packable.Weight;
        }
        public double TotalWeight(PackableBrick packable, ParamSetPackOptim constraintSet)
        {
            return InnerWeight(packable) + EmptyWeight(packable, constraintSet);                    
        }
        #endregion

        #region Public methods referring CaseOptimizer
        /// <summary>
        /// Inner dimensions
        /// </summary>
        /// <param name="optimizer">Parent optimizer class</param>
        /// <returns>Inner dimensions stored in Vector3D</returns>
        public Vector3D InnerDimensions(PackableBrick packBrick)
        {
            return new Vector3D(
                _arrangement._iLength * packBrick.Dim(Dim0)
                , _arrangement._iWidth * packBrick.Dim(Dim1)
                , _arrangement._iHeight * packBrick.Dim(Dim2)
                );
        }
        /// <summary>
        ///  Outer dimensions
        /// </summary>
        /// <param name="optimizer">Parent optimizer class</param>
        /// <returns>Outer dimensions stored in Vector3D</returns>
        public Vector3D OuterDimensions(PackableBrick packBrick, ParamSetPackOptim paramSet)
        {
            return new Vector3D(
                _arrangement._iLength * packBrick.Dim(Dim0) + paramSet.WallThickness * paramSet.NoWalls[0]
                , _arrangement._iWidth * packBrick.Dim(Dim1) + paramSet.WallThickness * paramSet.NoWalls[1]
                , _arrangement._iHeight * packBrick.Dim(Dim2) + paramSet.WallThickness * paramSet.NoWalls[2]
                );
        }
        public Vector3D InnerOffset(ParamSetPackOptim paramSet)
        {
            return new Vector3D(
                0.5 * paramSet.WallThickness * paramSet.NoWalls[0]
                , 0.5 * paramSet.WallThickness * paramSet.NoWalls[1]
                , 0.5 * paramSet.WallThickness * paramSet.NoWalls[2]);
        }

        public double CaseEmptyWeight(PackableBrick boxProperties, ParamSetPackOptim paramSet)
        {
            return paramSet.WallSurfaceMass * Area(boxProperties, paramSet);
        }

        /// <summary>
        /// Returns true 
        /// </summary>
        /// <param name="optimizer"></param>
        /// <returns></returns>
        public bool IsValid(PackableBrick packable, ParamSetPackOptim paramSet)
        {
            Vector3D outerDim = OuterDimensions(packable, paramSet);
            return outerDim.X <= paramSet.CaseLimitMax.X && outerDim.Y <= paramSet.CaseLimitMax.Y && outerDim.Z <= paramSet.CaseLimitMax.Z
                && outerDim.X >= paramSet.CaseLimitMin.X && outerDim.Y >= paramSet.CaseLimitMin.Y && outerDim.Z >= paramSet.CaseLimitMin.Z
                && ((_dim0 == 0 && _dim1 == 1) || !paramSet.ForceVerticalcaseOrientation);
        }
        #endregion

        #region System.Object override
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} / ({1}, {2}, {3})", _arrangement.ToString(), Dim0, Dim1, Dim2);
            return sb.ToString();
        }
        #endregion

        #region Helpers
        public int Dim0 { get { return _dim0; } }
        public int Dim1 { get { return _dim1; } }
        public int Dim2 { get { return 3 - _dim0 - _dim1; } }
        #endregion
    }
    #endregion

    #region CaseOptimSolution
    /// <summary>
    /// Solution of CaseOptimAnalysis
    /// </summary>
    public class CaseOptimSolution
        : IComparable
    {
        #region Data members
        private CaseDefinition _caseDefinition;
        private CasePalletSolution _palletSolution;
        #endregion

        #region Constructor
        public CaseOptimSolution(CaseDefinition caseDefinition, CasePalletSolution palletSolution)
        {
            _caseDefinition = caseDefinition;
            _palletSolution = palletSolution;
        }
        #endregion

        #region Public properties
        public CasePalletSolution PalletSolution
        {  get { return _palletSolution; }  }
        public CaseDefinition CaseDefinition
        { get { return _caseDefinition; } }
        public int LayerCount
        { get { return _palletSolution.Count; } }
        public int CaseCount
        { get { return _palletSolution.CaseCount; } }
        #endregion

        #region IComparable
        public int CompareTo(object obj)
        {
            CaseOptimSolution sol = (CaseOptimSolution)obj;
            if (this.CaseCount > sol.CaseCount)
                return -1;
            else if (this.CaseCount == sol.CaseCount)
                return 0;
            else
                return 1;
        }
        #endregion

        #region System.Object overrides
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Case definition:");
            sb.Append(_caseDefinition.ToString());
            sb.Append(" - Pallet solution:");
            sb.Append(" Cases ");
            sb.Append(_palletSolution.CaseCount);
            sb.Append(" Layers ");
            sb.Append(_palletSolution.Count);
            return sb.ToString();
        }
        #endregion
    }
    #endregion
}
