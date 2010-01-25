﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

using TreeDim.StackBuilder.Basics;
using TreeDim.StackBuilder.Engine;
using TreeDim.StackBuilder.Graphics;

using Sharp3D.Math.Core;
#endregion

namespace TreeDim.StackBuilder.Engine.Test
{
    class Program
    {
        static int Main(string[] args)
        {
            try
            {
                // define box properties
                BoxProperties boxProperties = new BoxProperties(600, 400, 200);
                boxProperties.Weight = 1.0;
                boxProperties.SetColor(HalfAxis.AXIS_X_N, Color.Red);
                boxProperties.SetColor(HalfAxis.AXIS_X_P, Color.Red);
                boxProperties.SetColor(HalfAxis.AXIS_Y_N, Color.Green);
                boxProperties.SetColor(HalfAxis.AXIS_Y_P, Color.Green);
                boxProperties.SetColor(HalfAxis.AXIS_Z_N, Color.Blue);
                boxProperties.SetColor(HalfAxis.AXIS_Z_P, Color.Blue);
                Console.WriteLine(boxProperties.ToString());

                // define pallet properties
                PalletProperties palletProperties = new PalletProperties();
                palletProperties.Length = 2000;
                palletProperties.Width = 1500;
                palletProperties.Height = 100;
                Console.WriteLine("=== Pallet properties ===");
                Console.WriteLine(palletProperties.ToString());

                // define constraints
                ConstraintSet constraintSet = new ConstraintSet();
                constraintSet.MaximumPalletWeight = 1000.0;
                constraintSet.MaximumNumberOfItems = 1000;
                constraintSet.MaximumHeight = 3000;
                constraintSet.UseMaximumHeight = true;
                constraintSet.UseMaximumPalletWeight = true;
                constraintSet.UseMaximumWeightOnBox = false;
                Console.WriteLine("=== Constraint set ===");
                Console.WriteLine(constraintSet.ToString());


                // initialize solver
                Solver solver = new Solver();
                solver.Box = boxProperties;
                solver.Pallet = palletProperties;
                solver.ConstraintSet = constraintSet;
                List<Solution> solutions = solver.GenerateSolutions();

                Console.WriteLine("=== Solutions ===");
                int solIndex = 0;
                foreach (Solution sol in solutions)
                {
                    // instantiate graphics
                    Graphics3DImage graphics = new Graphics3DImage(new Size(1000, 1000));
                    graphics.CameraPosition = new Vector3D(10000.0, 10000.0, 10000.0);
                    graphics.Target = new Vector3D(0.0, 0.0, 0.0);
                    graphics.LightDirection = new Vector3D(-0.75, -0.5, 1.0);
                    graphics.SetViewport(-500.0f, -500.0f, 500.0f, 500.0f);
                    // instantiate solution viewer
                    SolutionViewer sv = new SolutionViewer();
                    sv.Box = boxProperties;
                    sv.Solution = sol;
                    sv.Draw(graphics);
                    // save
                    string fileName = string.Format("Pallet_{0}.bmp", solIndex++);
                    string filePath = Path.Combine(Path.GetTempPath(), fileName);
                    Console.WriteLine("Saving file " + filePath + "...");
                    graphics.SaveAs(filePath);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return 0;
        }
    }
}
