﻿#region Using directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
#endregion

namespace treeDiM.StackBuilder.Basics
{
    public partial class UCtrlDualDouble : UserControl
    {
        #region Delegates
        public delegate void onValueChanged(object sender, EventArgs args);
        #endregion

        #region Events
        public event onValueChanged ValueChanged;
        #endregion

        #region Constructor
        public UCtrlDualDouble()
        {
            InitializeComponent();
        }
        #endregion

        #region Public properties
        [Browsable(true),
        EditorBrowsable(EditorBrowsableState.Always),
        DesignerSerializationVisibility(DesignerSerializationVisibility.Visible),
        Category("Appearance")]
        public override string Text
        {
            get { return lbName.Text; }
            set { lbName.Text = value; }
        }
        [Browsable(true)]
        public double ValueX { get { return (double)nudValueX.Value; } set { nudValueX.Value = (decimal)value; } }
        [Browsable(true)]
        public double ValueY { get { return (double)nudValueY.Value; } set { nudValueY.Value = (decimal)value; } }
        [Browsable(true)]
        public UnitsManager.UnitType Unit
        {
            get { return _unitType; }
            set
            {
                _unitType = value;
                lbUnit.Text = UnitsManager.UnitString(_unitType);
                nudValueX.DecimalPlaces = UnitsManager.NoDecimals(_unitType);
                nudValueY.DecimalPlaces = UnitsManager.NoDecimals(_unitType);
            }
        }
        [Browsable(true)]
        public double MinValue
        {
            set
            {
                nudValueX.Minimum = (decimal)value;
                nudValueY.Minimum = (decimal)value;
            }
            get { return (double)nudValueX.Minimum; }
        }
        #endregion

        #region Event handlers
        private void nudValue_ValueChanged(object sender, EventArgs e)
        {
            if (null != ValueChanged) ValueChanged(this, e);
        }
        private void ValueControl_SizeChanged(object sender, EventArgs e)
        {
            // set nud location
            nudValueX.Location = new Point(Width - 2 * UCtrlDualDouble.stNudLength - 2 - UCtrlDualDouble.stLbUnitLength, 0);
            nudValueY.Location = new Point(Width - UCtrlDualDouble.stNudLength - UCtrlDualDouble.stLbUnitLength, 0);
            // set unit location
            lbUnit.Location = new Point(Width - UCtrlDualDouble.stLbUnitLength + 1, 4);
        }
        #endregion

        #region Data members
        private UnitsManager.UnitType _unitType;
        public static int stNudLength = 60;
        public static int stLbUnitLength = 38;
        #endregion
    }
}
