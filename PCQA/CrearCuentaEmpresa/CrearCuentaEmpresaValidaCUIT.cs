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
    ///The CrearCuentaEmpresaValidaCUIT recording.
    /// </summary>
    [TestModule("10ef46c3-18df-441d-b5ac-98544abdbd4e", ModuleType.Recording, 1)]
    public partial class CrearCuentaEmpresaValidaCUIT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::PCQA.PCQARepository repository.
        /// </summary>
        public static global::PCQA.PCQARepository repo = global::PCQA.PCQARepository.Instance;

        static CrearCuentaEmpresaValidaCUIT instance = new CrearCuentaEmpresaValidaCUIT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CrearCuentaEmpresaValidaCUIT()
        {
            Documento = "30712284885";
            IVA = "Exento";
            IBB = "Exento";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CrearCuentaEmpresaValidaCUIT Instance
        {
            get { return instance; }
        }

#region Variables

        string _Documento;

        /// <summary>
        /// Gets or sets the value of variable Documento.
        /// </summary>
        [TestVariable("4d329156-5c54-42da-9e7d-953e7105311e")]
        public string Documento
        {
            get { return _Documento; }
            set { _Documento = value; }
        }

        string _IVA;

        /// <summary>
        /// Gets or sets the value of variable IVA.
        /// </summary>
        [TestVariable("2ee18b9d-1ea1-49ba-ab57-f21e7a883a17")]
        public string IVA
        {
            get { return _IVA; }
            set { _IVA = value; }
        }

        string _IBB;

        /// <summary>
        /// Gets or sets the value of variable IBB.
        /// </summary>
        [TestVariable("4d13860e-fa25-4fc5-89c0-3b16df1665ad")]
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.txt_Cuit' at Center.", repo.ApplicationUnderTest.XTableLayout.txt_CuitInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.XTableLayout.txt_Cuit.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Documento' with focus on 'ApplicationUnderTest.XTableLayout.txt_Cuit'.", repo.ApplicationUnderTest.XTableLayout.txt_CuitInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.XTableLayout.txt_Cuit.PressKeys(Documento);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.lbl_Identificacion' at Center.", repo.ApplicationUnderTest.XTableLayout.lbl_IdentificacionInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.XTableLayout.lbl_Identificacion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.XTableLayout.txt_Cuit_Espera'", repo.ApplicationUnderTest.XTableLayout.txt_Cuit_EsperaInfo, new ActionTimeout(30000), new RecordItemIndex(3));
            repo.ApplicationUnderTest.XTableLayout.txt_Cuit_EsperaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.btn_ValidarDocumento' at Center.", repo.ApplicationUnderTest.btn_ValidarDocumentoInfo, new RecordItemIndex(4));
            repo.ApplicationUnderTest.btn_ValidarDocumento.Click();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Click item 'ApplicationUnderTest.Seleccionar' at 37;13.", repo.ApplicationUnderTest.SeleccionarInfo, new RecordItemIndex(5));
                repo.ApplicationUnderTest.Seleccionar.Click("37;13");
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.btn_ValidarDocumento_Espera'", repo.ApplicationUnderTest.btn_ValidarDocumento_EsperaInfo, new ActionTimeout(30000), new RecordItemIndex(6));
            //repo.ApplicationUnderTest.btn_ValidarDocumento_EsperaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 6s.", new RecordItemIndex(7));
            Delay.Duration(6000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.FlechaSelectIva' at Center.", repo.ApplicationUnderTest.XTableLayout.FlechaSelectIvaInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.XTableLayout.FlechaSelectIva.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$IVA' with focus on 'ApplicationUnderTest.txt_IVA'.", repo.ApplicationUnderTest.txt_IVAInfo, new RecordItemIndex(9));
            repo.ApplicationUnderTest.txt_IVA.PressKeys(IVA);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.CondicionFiscal' at Center.", repo.ApplicationUnderTest.XTableLayout.CondicionFiscalInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.XTableLayout.CondicionFiscal.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.txt_IVA_Espera'", repo.ApplicationUnderTest.txt_IVA_EsperaInfo, new ActionTimeout(30000), new RecordItemIndex(11));
            repo.ApplicationUnderTest.txt_IVA_EsperaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.FlechaSelectIBB' at Center.", repo.ApplicationUnderTest.XTableLayout.FlechaSelectIBBInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.XTableLayout.FlechaSelectIBB.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$IBB' with focus on 'ApplicationUnderTest.txt_IBB'.", repo.ApplicationUnderTest.txt_IBBInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.txt_IBB.PressKeys(IBB);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.CondicionFiscal' at Center.", repo.ApplicationUnderTest.XTableLayout.CondicionFiscalInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.XTableLayout.CondicionFiscal.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.txt_IBB_Espera'", repo.ApplicationUnderTest.txt_IBB_EsperaInfo, new ActionTimeout(30000), new RecordItemIndex(15));
            repo.ApplicationUnderTest.txt_IBB_EsperaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.ClickFlechaBuscaGrupo2' at CenterRight.", repo.ApplicationUnderTest.XTableLayout.ClickFlechaBuscaGrupo2Info, new RecordItemIndex(16));
            repo.ApplicationUnderTest.XTableLayout.ClickFlechaBuscaGrupo2.Click(Location.CenterRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BuscarGrupo' at Center.", repo.ApplicationUnderTest.BuscarGrupoInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.BuscarGrupo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Validar_BuscarGrupos' at 112;14.", repo.ApplicationUnderTest.Validar_BuscarGruposInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.Validar_BuscarGrupos.Click("112;14");
            Delay.Milliseconds(0);
            
            // **** Validación de Carga de Datos de la Cuenta exitoso ****
            Report.Log(ReportLevel.Info, "Section", "**** Validación de Carga de Datos de la Cuenta exitoso ****", new RecordItemIndex(19));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Buscar grupos') on item 'ApplicationUnderTest.Validar_BuscarGrupos'.", repo.ApplicationUnderTest.Validar_BuscarGruposInfo, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Validar_BuscarGruposInfo, "InnerText", "Buscar grupos");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
