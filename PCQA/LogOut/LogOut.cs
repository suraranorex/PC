﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace PCQA.LogOut
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LogOut recording.
    /// </summary>
    [TestModule("e63d618d-91f9-4211-a7c3-02920791d1e2", ModuleType.Recording, 1)]
    public partial class LogOut : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::PCQA.PCQARepository repository.
        /// </summary>
        public static global::PCQA.PCQARepository repo = global::PCQA.PCQARepository.Instance;

        static LogOut instance = new LogOut();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LogOut()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LogOut Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable Ambiente.
        /// </summary>
        [TestVariable("6220ee55-3dcc-4717-9260-d89ec7bc2052")]
        public string Ambiente
        {
            get { return repo.Ambiente; }
            set { repo.Ambiente = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.GPreferencesIconXBtnIconElXBtnI' at 7;7.", repo.ApplicationUnderTest.GPreferencesIconXBtnIconElXBtnIInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.GPreferencesIconXBtnIconElXBtnI.Click("7;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(1));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CerrarSesionSuperUser' at Center.", repo.ApplicationUnderTest.CerrarSesionSuperUserInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.CerrarSesionSuperUser.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.bttn_Aceptar' at 21;7.", repo.ApplicationUnderTest.bttn_AceptarInfo, new RecordItemIndex(3));
            repo.ApplicationUnderTest.bttn_Aceptar.Click("21;7");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
