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
    ///The CrearCuentaCompaniaSinValidarCUIT recording.
    /// </summary>
    [TestModule("273e0e5a-bf26-4c5e-9a1e-26bb7dbff4bc", ModuleType.Recording, 1)]
    public partial class CrearCuentaCompaniaSinValidarCUIT : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::PCQA.PCQARepository repository.
        /// </summary>
        public static global::PCQA.PCQARepository repo = global::PCQA.PCQARepository.Instance;

        static CrearCuentaCompaniaSinValidarCUIT instance = new CrearCuentaCompaniaSinValidarCUIT();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public CrearCuentaCompaniaSinValidarCUIT()
        {
            Documento = "30712284885";
            IVA = "No Responsable";
            IBB = "Exento";
            RazonSocial = "UBER B.V. Y/O RASIER OPERATIONS B.V. Y/O UBER PORTIER B.V.";
            correoprincipal = "aseguradosgw@gmail.com";
            Provincia = "CATAMARCA";
            Localidad = "FIAMBALA";
            Calle = "Jujuy";
            NumeroCalle = "200";
            Pais = "Países Bajos";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static CrearCuentaCompaniaSinValidarCUIT Instance
        {
            get { return instance; }
        }

#region Variables

        string _Documento;

        /// <summary>
        /// Gets or sets the value of variable Documento.
        /// </summary>
        [TestVariable("062c78ef-378e-4468-831d-0603bb05ebc4")]
        public string Documento
        {
            get { return _Documento; }
            set { _Documento = value; }
        }

        string _IVA;

        /// <summary>
        /// Gets or sets the value of variable IVA.
        /// </summary>
        [TestVariable("9af5e80a-0d5f-43d2-af35-1517e59f6296")]
        public string IVA
        {
            get { return _IVA; }
            set { _IVA = value; }
        }

        string _IBB;

        /// <summary>
        /// Gets or sets the value of variable IBB.
        /// </summary>
        [TestVariable("0b5ed77f-d17e-4888-b75b-695f66618e12")]
        public string IBB
        {
            get { return _IBB; }
            set { _IBB = value; }
        }

        string _RazonSocial;

        /// <summary>
        /// Gets or sets the value of variable RazonSocial.
        /// </summary>
        [TestVariable("c0e07ad1-a15d-4e95-8035-2f72523c3ae0")]
        public string RazonSocial
        {
            get { return _RazonSocial; }
            set { _RazonSocial = value; }
        }

        string _correoprincipal;

        /// <summary>
        /// Gets or sets the value of variable correoprincipal.
        /// </summary>
        [TestVariable("919f69b3-9f6f-417a-afed-b9db92579c30")]
        public string correoprincipal
        {
            get { return _correoprincipal; }
            set { _correoprincipal = value; }
        }

        string _Pais;

        /// <summary>
        /// Gets or sets the value of variable Pais.
        /// </summary>
        [TestVariable("b27e1f87-14eb-49c2-b39d-56cc29496f90")]
        public string Pais
        {
            get { return _Pais; }
            set { _Pais = value; }
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
        /// Gets or sets the value of variable Provincia.
        /// </summary>
        [TestVariable("50ed28dc-e649-4ebd-875d-86b3b4c7730b")]
        public string Provincia
        {
            get { return repo.Provincia; }
            set { repo.Provincia = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Localidad.
        /// </summary>
        [TestVariable("91126537-cf8a-4d6d-b18c-3e5e68aa547e")]
        public string Localidad
        {
            get { return repo.Localidad; }
            set { repo.Localidad = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Calle.
        /// </summary>
        [TestVariable("db20bf29-eb70-460b-8e0c-3de1f5451e90")]
        public string Calle
        {
            get { return repo.Calle; }
            set { repo.Calle = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable NumeroCalle.
        /// </summary>
        [TestVariable("24c49e56-80bb-4175-88f1-6993e01dfcca")]
        public string NumeroCalle
        {
            get { return repo.NumeroCalle; }
            set { repo.NumeroCalle = value; }
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
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.btn_ValidarDocumento' at Center.", repo.ApplicationUnderTest.btn_ValidarDocumentoInfo, new RecordItemIndex(4));
            //repo.ApplicationUnderTest.btn_ValidarDocumento.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.btn_ValidarDocumento_Espera'", repo.ApplicationUnderTest.btn_ValidarDocumento_EsperaInfo, new ActionTimeout(30000), new RecordItemIndex(5));
            //repo.ApplicationUnderTest.btn_ValidarDocumento_EsperaInfo.WaitForNotExists(30000);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 6s.", new RecordItemIndex(6));
            //Delay.Duration(6000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.txt_RazonSocial' at Center.", repo.ApplicationUnderTest.XTableLayout.txt_RazonSocialInfo, new RecordItemIndex(7));
            repo.ApplicationUnderTest.XTableLayout.txt_RazonSocial.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$RazonSocial' with focus on 'ApplicationUnderTest.XTableLayout.txt_RazonSocial'.", repo.ApplicationUnderTest.XTableLayout.txt_RazonSocialInfo, new RecordItemIndex(8));
            repo.ApplicationUnderTest.XTableLayout.txt_RazonSocial.PressKeys(RazonSocial);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.XTableLayout.Copy_of_txt_RazonSocial'", repo.ApplicationUnderTest.XTableLayout.Copy_of_txt_RazonSocialInfo, new ActionTimeout(30000), new RecordItemIndex(9));
            repo.ApplicationUnderTest.XTableLayout.Copy_of_txt_RazonSocialInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.FlechaSelectIva' at Center.", repo.ApplicationUnderTest.XTableLayout.FlechaSelectIvaInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.XTableLayout.FlechaSelectIva.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$IVA' with focus on 'ApplicationUnderTest.txt_IVA'.", repo.ApplicationUnderTest.txt_IVAInfo, new RecordItemIndex(11));
            repo.ApplicationUnderTest.txt_IVA.PressKeys(IVA);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.CondicionFiscal' at Center.", repo.ApplicationUnderTest.XTableLayout.CondicionFiscalInfo, new RecordItemIndex(12));
            repo.ApplicationUnderTest.XTableLayout.CondicionFiscal.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.txt_IVA_Espera'", repo.ApplicationUnderTest.txt_IVA_EsperaInfo, new ActionTimeout(30000), new RecordItemIndex(13));
            repo.ApplicationUnderTest.txt_IVA_EsperaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.FlechaSelectIBB' at Center.", repo.ApplicationUnderTest.XTableLayout.FlechaSelectIBBInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.XTableLayout.FlechaSelectIBB.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$IBB' with focus on 'ApplicationUnderTest.txt_IBB'.", repo.ApplicationUnderTest.txt_IBBInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.txt_IBB.PressKeys(IBB);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.CondicionFiscal' at Center.", repo.ApplicationUnderTest.XTableLayout.CondicionFiscalInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.XTableLayout.CondicionFiscal.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.txt_IBB_Espera'", repo.ApplicationUnderTest.txt_IBB_EsperaInfo, new ActionTimeout(30000), new RecordItemIndex(17));
            repo.ApplicationUnderTest.txt_IBB_EsperaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.txt_CorreoPrincipal' at Center.", repo.ApplicationUnderTest.txt_CorreoPrincipalInfo, new RecordItemIndex(18));
            repo.ApplicationUnderTest.txt_CorreoPrincipal.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$correoprincipal' with focus on 'ApplicationUnderTest.txt_CorreoPrincipal'.", repo.ApplicationUnderTest.txt_CorreoPrincipalInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.txt_CorreoPrincipal.PressKeys(correoprincipal);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.lbl_Email' at Center.", repo.ApplicationUnderTest.lbl_EmailInfo, new RecordItemIndex(20));
            repo.ApplicationUnderTest.lbl_Email.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.Copy_of_txt_CorreoPrincipal'", repo.ApplicationUnderTest.Copy_of_txt_CorreoPrincipalInfo, new ActionTimeout(30000), new RecordItemIndex(21));
            repo.ApplicationUnderTest.Copy_of_txt_CorreoPrincipalInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.txtPais' at Center.", repo.ApplicationUnderTest.txtPaisInfo, new RecordItemIndex(22));
            repo.ApplicationUnderTest.txtPais.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'ApplicationUnderTest.txtPais'.", repo.ApplicationUnderTest.txtPaisInfo, new RecordItemIndex(23));
            repo.ApplicationUnderTest.txtPais.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Pais' with focus on 'ApplicationUnderTest.txtPais'.", repo.ApplicationUnderTest.txtPaisInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.txtPais.PressKeys(Pais);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.Copy_of_txtPais'", repo.ApplicationUnderTest.Copy_of_txtPaisInfo, new ActionTimeout(30000), new RecordItemIndex(25));
            repo.ApplicationUnderTest.Copy_of_txtPaisInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.Click_Provincia' at 11;14.", repo.ApplicationUnderTest.XTableLayout.Click_ProvinciaInfo, new RecordItemIndex(26));
            repo.ApplicationUnderTest.XTableLayout.Click_Provincia.Click("11;14");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.PrimerItemProvincia'", repo.ApplicationUnderTest.PrimerItemProvinciaInfo, new ActionTimeout(30000), new RecordItemIndex(27));
            repo.ApplicationUnderTest.PrimerItemProvinciaInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Provincia' with focus on 'ApplicationUnderTest.txtProvincia'.", repo.ApplicationUnderTest.txtProvinciaInfo, new RecordItemIndex(28));
            repo.ApplicationUnderTest.txtProvincia.PressKeys(Provincia);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ItemProvincia' at Center.", repo.ApplicationUnderTest.ItemProvinciaInfo, new RecordItemIndex(29));
            repo.ApplicationUnderTest.ItemProvincia.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to not exist. Associated repository item: 'ApplicationUnderTest.Copy_of_txtProvincia'", repo.ApplicationUnderTest.Copy_of_txtProvinciaInfo, new ActionTimeout(30000), new RecordItemIndex(30));
            repo.ApplicationUnderTest.Copy_of_txtProvinciaInfo.WaitForNotExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.Click_Localidad' at Center.", repo.ApplicationUnderTest.XTableLayout.Click_LocalidadInfo, new RecordItemIndex(31));
            repo.ApplicationUnderTest.XTableLayout.Click_Localidad.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.PrimerItemLocalidad'", repo.ApplicationUnderTest.PrimerItemLocalidadInfo, new ActionTimeout(30000), new RecordItemIndex(32));
            repo.ApplicationUnderTest.PrimerItemLocalidadInfo.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}{Akey}{LControlKey up}' with focus on 'ApplicationUnderTest.XTableLayout.Click_Localidad'.", repo.ApplicationUnderTest.XTableLayout.Click_LocalidadInfo, new RecordItemIndex(33));
            repo.ApplicationUnderTest.XTableLayout.Click_Localidad.PressKeys("{LControlKey down}{Akey}{LControlKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Localidad' with focus on 'ApplicationUnderTest.XTableLayout.Click_Localidad'.", repo.ApplicationUnderTest.XTableLayout.Click_LocalidadInfo, new RecordItemIndex(34));
            repo.ApplicationUnderTest.XTableLayout.Click_Localidad.PressKeys(Localidad);
            Delay.Milliseconds(20);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ItemLocalidad' at Center.", repo.ApplicationUnderTest.ItemLocalidadInfo, new RecordItemIndex(35));
            //repo.ApplicationUnderTest.ItemLocalidad.Click();
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 50s to not exist. Associated repository item: 'ApplicationUnderTest.XTableLayout.Copy_of_Click_Localidad'", repo.ApplicationUnderTest.XTableLayout.Copy_of_Click_LocalidadInfo, new ActionTimeout(50000), new RecordItemIndex(36));
            repo.ApplicationUnderTest.XTableLayout.Copy_of_Click_LocalidadInfo.WaitForNotExists(50000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.lbl_Direccion' at Center.", repo.ApplicationUnderTest.lbl_DireccionInfo, new RecordItemIndex(37));
            repo.ApplicationUnderTest.lbl_Direccion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.txt_Calle' at Center.", repo.ApplicationUnderTest.XTableLayout.txt_CalleInfo, new RecordItemIndex(38));
            repo.ApplicationUnderTest.XTableLayout.txt_Calle.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Calle' with focus on 'ApplicationUnderTest.XTableLayout.txt_Calle'.", repo.ApplicationUnderTest.XTableLayout.txt_CalleInfo, new RecordItemIndex(39));
            repo.ApplicationUnderTest.XTableLayout.txt_Calle.PressKeys(Calle);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.lbl_Direccion' at Center.", repo.ApplicationUnderTest.lbl_DireccionInfo, new RecordItemIndex(40));
            repo.ApplicationUnderTest.lbl_Direccion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 50s to not exist. Associated repository item: 'ApplicationUnderTest.XTableLayout.txt_Calle_Espera'", repo.ApplicationUnderTest.XTableLayout.txt_Calle_EsperaInfo, new ActionTimeout(50000), new RecordItemIndex(41));
            repo.ApplicationUnderTest.XTableLayout.txt_Calle_EsperaInfo.WaitForNotExists(50000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.txt_Numero' at Center.", repo.ApplicationUnderTest.XTableLayout.txt_NumeroInfo, new RecordItemIndex(42));
            repo.ApplicationUnderTest.XTableLayout.txt_Numero.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$NumeroCalle' with focus on 'ApplicationUnderTest.XTableLayout.txt_Numero'.", repo.ApplicationUnderTest.XTableLayout.txt_NumeroInfo, new RecordItemIndex(43));
            repo.ApplicationUnderTest.XTableLayout.txt_Numero.EnsureVisible();
            Keyboard.Press(NumeroCalle);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.lbl_Direccion' at Center.", repo.ApplicationUnderTest.lbl_DireccionInfo, new RecordItemIndex(44));
            repo.ApplicationUnderTest.lbl_Direccion.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 50s to not exist. Associated repository item: 'ApplicationUnderTest.XTableLayout.Copy_of_txt_Numero'", repo.ApplicationUnderTest.XTableLayout.Copy_of_txt_NumeroInfo, new ActionTimeout(50000), new RecordItemIndex(45));
            repo.ApplicationUnderTest.XTableLayout.Copy_of_txt_NumeroInfo.WaitForNotExists(50000);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1097' with focus on 'ApplicationUnderTest.txtCodigoPostalUber'.", repo.ApplicationUnderTest.txtCodigoPostalUberInfo, new RecordItemIndex(46));
            repo.ApplicationUnderTest.txtCodigoPostalUber.PressKeys("1097");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.Btn_ValidarDireccion' at Center.", repo.ApplicationUnderTest.XTableLayout.Btn_ValidarDireccionInfo, new RecordItemIndex(47));
            //repo.ApplicationUnderTest.XTableLayout.Btn_ValidarDireccion.Click();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 8s.", new RecordItemIndex(48));
            //Delay.Duration(8000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.XTableLayout.ClickFlechaBuscaGrupo2' at CenterRight.", repo.ApplicationUnderTest.XTableLayout.ClickFlechaBuscaGrupo2Info, new RecordItemIndex(49));
            repo.ApplicationUnderTest.XTableLayout.ClickFlechaBuscaGrupo2.Click(Location.CenterRight);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.BuscarGrupo' at Center.", repo.ApplicationUnderTest.BuscarGrupoInfo, new RecordItemIndex(50));
            repo.ApplicationUnderTest.BuscarGrupo.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Validar_BuscarGrupos' at 112;14.", repo.ApplicationUnderTest.Validar_BuscarGruposInfo, new RecordItemIndex(51));
            repo.ApplicationUnderTest.Validar_BuscarGrupos.Click("112;14");
            Delay.Milliseconds(0);
            
            // **** Validación de Carga de Datos de la Cuenta exitoso ****
            Report.Log(ReportLevel.Info, "Section", "**** Validación de Carga de Datos de la Cuenta exitoso ****", new RecordItemIndex(52));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Buscar grupos') on item 'ApplicationUnderTest.Validar_BuscarGrupos'.", repo.ApplicationUnderTest.Validar_BuscarGruposInfo, new RecordItemIndex(53));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Validar_BuscarGruposInfo, "InnerText", "Buscar grupos");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}