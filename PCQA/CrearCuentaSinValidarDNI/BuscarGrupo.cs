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

namespace PCQA.CrearCuentaSinValidarDNI
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The BuscarGrupo recording.
    /// </summary>
    [TestModule("aac03aae-ea94-4ab9-a2c8-d3b1fadfd2b0", ModuleType.Recording, 1)]
    public partial class BuscarGrupo : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::PCQA.PCQARepository repository.
        /// </summary>
        public static global::PCQA.PCQARepository repo = global::PCQA.PCQARepository.Instance;

        static BuscarGrupo instance = new BuscarGrupo();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BuscarGrupo()
        {
            PAS = "8371";
            NroCuenta = "";
            PASNombre = "";
            NombreProductor = "Grupo Gdansk-Litoral";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static BuscarGrupo Instance
        {
            get { return instance; }
        }

#region Variables

        string _NroCuenta;

        /// <summary>
        /// Gets or sets the value of variable NroCuenta.
        /// </summary>
        [TestVariable("6035d2ea-8259-4cbf-86da-a0ed267b3c8e")]
        public string NroCuenta
        {
            get { return _NroCuenta; }
            set { _NroCuenta = value; }
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

        /// <summary>
        /// Gets or sets the value of variable NombreProductor.
        /// </summary>
        [TestVariable("88b5136d-85bb-4c8c-bc17-dacfb1fe6f47")]
        public string NombreProductor
        {
            get { return repo.NombreProductor; }
            set { repo.NombreProductor = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable PAS.
        /// </summary>
        [TestVariable("f0ddb07f-2986-4e1d-bb32-e20ae95ac80f")]
        public string PAS
        {
            get { return repo.PAS; }
            set { repo.PAS = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable PASNombre.
        /// </summary>
        [TestVariable("f6246757-cb60-4f80-8f43-eedf61ae9820")]
        public string PASNombre
        {
            get { return repo.PASNombre; }
            set { repo.PASNombre = value; }
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

            // **** Buscar Grupo ****
            Report.Log(ReportLevel.Info, "Section", "**** Buscar Grupo ****", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Txt_Cod_PAS' at 57;15.", repo.SURA.Txt_Cod_PASInfo, new RecordItemIndex(1));
            repo.SURA.Txt_Cod_PAS.Click("57;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'SURA.Txt_Cod_PAS'.", repo.SURA.Txt_Cod_PASInfo, new RecordItemIndex(2));
            Keyboard.PrepareFocus(repo.SURA.Txt_Cod_PAS);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PAS' with focus on 'SURA.Txt_Cod_PAS'.", repo.SURA.Txt_Cod_PASInfo, new RecordItemIndex(3));
            repo.SURA.Txt_Cod_PAS.PressKeys(PAS);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Btn_BuscarPAS' at Center.", repo.SURA.Btn_BuscarPASInfo, new RecordItemIndex(4));
            repo.SURA.Btn_BuscarPAS.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.SeleccionarPAS' at 38;13.", repo.SURA.SeleccionarPASInfo, new RecordItemIndex(5));
            repo.SURA.SeleccionarPAS.Click("38;13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(6));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.XTableLayout.FlechaCodPAS' at 7;7.", repo.SURA.XTableLayout.FlechaCodPASInfo, new RecordItemIndex(7));
            repo.SURA.XTableLayout.FlechaCodPAS.Click("7;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.txt_CodPas' at Center.", repo.SURA.txt_CodPasInfo, new RecordItemIndex(8));
            repo.SURA.txt_CodPas.Click();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.XTableLayout.FlechaCodPAS' at Center.", repo.SURA.XTableLayout.FlechaCodPASInfo, new RecordItemIndex(9));
            //repo.SURA.XTableLayout.FlechaCodPAS.Click();
            //Delay.Milliseconds(0);
            
            //PASNombreProductor();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "User", PASNombre, new RecordItemIndex(11));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$PAS' with focus on 'SURA.txt_CodPas'.", repo.SURA.txt_CodPasInfo, new RecordItemIndex(12));
            repo.SURA.txt_CodPas.PressKeys(PAS);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.ItemPasNombre' at Center.", repo.SURA.ItemPasNombreInfo, new RecordItemIndex(13));
            repo.SURA.ItemPasNombre.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(14));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Btn_Actualizar' at 44;7.", repo.SURA.Btn_ActualizarInfo, new RecordItemIndex(15));
            repo.SURA.Btn_Actualizar.Click("44;7");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'SURA.NroCuenta' and assigning its value to variable 'NroCuenta'.", repo.SURA.NroCuentaInfo, new RecordItemIndex(16));
            NroCuenta = repo.SURA.NroCuenta.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", "El número de cuenta es:", new RecordItemIndex(17));
            
            Report.Log(ReportLevel.Info, "User", NroCuenta, new RecordItemIndex(18));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SURA.Validar_ResumenDelArchivoDeCuenta' at 117;11.", repo.SURA.Validar_ResumenDelArchivoDeCuentaInfo, new RecordItemIndex(19));
            repo.SURA.Validar_ResumenDelArchivoDeCuenta.Click("117;11");
            Delay.Milliseconds(0);
            
            // **** Validación de cuenta creada exitosamente ****
            Report.Log(ReportLevel.Info, "Section", "**** Validación de cuenta creada exitosamente ****", new RecordItemIndex(20));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Resumen del archivo de cuenta') on item 'SURA.Validar_ResumenDelArchivoDeCuenta'.", repo.SURA.Validar_ResumenDelArchivoDeCuentaInfo, new RecordItemIndex(21));
            Validate.AttributeEqual(repo.SURA.Validar_ResumenDelArchivoDeCuentaInfo, "InnerText", "Resumen del archivo de cuenta");
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.SURA.Validar_ResumenDelArchivoDeCuenta, false, new RecordItemIndex(22));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
