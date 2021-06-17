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

namespace PCQA.CrearCuentaEmpresa
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The CrearCuentaCompania recording.
    /// </summary>
    [TestModule("3fd738df-2a3d-4f63-9e33-82c60c470629", ModuleType.Recording, 1)]
    public partial class CrearCuentaCompania : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::PCQA.PCQARepository repository.
        /// </summary>
        public static global::PCQA.PCQARepository repo = global::PCQA.PCQARepository.Instance;

        static CrearCuentaCompania instance = new CrearCuentaCompania();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CrearCuentaCompania()
        {
            Documento = "30712284885";
            IVA = "Exento";
            IBB = "Exento";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CrearCuentaCompania Instance
        {
            get { return instance; }
        }

#region Variables

        string _Documento;

        /// <summary>
        /// Gets or sets the value of variable Documento.
        /// </summary>
        [TestVariable("59692992-53dd-44ad-a2e8-127e8b31c57e")]
        public string Documento
        {
            get { return _Documento; }
            set { _Documento = value; }
        }

        string _IVA;

        /// <summary>
        /// Gets or sets the value of variable IVA.
        /// </summary>
        [TestVariable("7d20cfe1-1259-449b-b46d-a1fbdd2eb884")]
        public string IVA
        {
            get { return _IVA; }
            set { _IVA = value; }
        }

        string _IBB;

        /// <summary>
        /// Gets or sets the value of variable IBB.
        /// </summary>
        [TestVariable("a96c9526-9e49-41f4-9eee-ab2309776f1d")]
        public string IBB
        {
            get { return _IBB; }
            set { _IBB = value; }
        }

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.XTableLayout.txt_Cuit' at Center.", repo.SURA.XTableLayout.txt_CuitInfo, new RecordItemIndex(0));
            repo.SURA.XTableLayout.txt_Cuit.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Documento' with focus on 'SURA.XTableLayout.txt_Cuit'.", repo.SURA.XTableLayout.txt_CuitInfo, new RecordItemIndex(1));
            repo.SURA.XTableLayout.txt_Cuit.PressKeys(Documento);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.XTableLayout.lbl_Identificacion' at Center.", repo.SURA.XTableLayout.lbl_IdentificacionInfo, new RecordItemIndex(2));
            repo.SURA.XTableLayout.lbl_Identificacion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.XTableLayout.txt_Cuit_Espera'", repo.SURA.XTableLayout.txt_Cuit_EsperaInfo, new ActionTimeout(30000), new RecordItemIndex(3));
            repo.SURA.XTableLayout.txt_Cuit_EsperaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.btn_ValidarDocumento' at Center.", repo.SURA.btn_ValidarDocumentoInfo, new RecordItemIndex(4));
            repo.SURA.btn_ValidarDocumento.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'SURA.btn_ValidarDocumento_Espera'", repo.SURA.btn_ValidarDocumento_EsperaInfo, new ActionTimeout(30000), new RecordItemIndex(5));
            //repo.SURA.btn_ValidarDocumento_EsperaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 6s.", new RecordItemIndex(6));
            Delay.Duration(6000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
