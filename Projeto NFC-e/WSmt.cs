﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Security.Cryptography.X509Certificates;

namespace Projeto_NFC_e
{
    class WSmt
    {
         private XmlNode XmlEnvio;
         private sefaznfe.NfeStatusServico2 wsSer = new sefaznfe.NfeStatusServico2();
         public WSmt()
        {
            string WSstats = null;
            WSstats = "<consStatServ xmlns=" + '"' + "http://www.portalfiscal.inf.br/nfe" + '"' + " versao=" + '"' + "3.10" + '"' + ">";
            WSstats += "<tpAmb>1</tpAmb>";
            WSstats += "<cUF>51</cUF>";
            WSstats += "<xServ>STATUS</xServ>";
            WSstats += "</consStatServ>";

            System.Xml.XmlDocument XmlArq = new System.Xml.XmlDocument();
            XmlArq.PreserveWhitespace = true;
            XmlArq.LoadXml(WSstats);
            XmlEnvio = XmlArq.DocumentElement;

            sefaznfe.nfeCabecMsg wsCab = new sefaznfe.nfeCabecMsg();


            wsCab.cUF = "51";
            wsCab.versaoDados = "3.10";
            wsSer.nfeCabecMsgValue = wsCab;

            X509Certificate2Collection lcerts;
            X509Store lStore = new X509Store(StoreName.My, StoreLocation.LocalMachine);

            // Abre o Store
            lStore.Open(OpenFlags.OpenExistingOnly);

            // Lista os certificados
            lcerts = lStore.Certificates;
            string NumSerie = "4FC5BEEB6E9DCB48";
            foreach (X509Certificate2 cert in lcerts)
            {
                if (NumSerie == cert.SerialNumber)
                {

                    wsSer.ClientCertificates.Add(cert);
                }
                else
                {
                    MessageBox.Show("O Número de Série " + cert.SerialNumber + " não foi encontrado.");

                }
            }

            lStore.Close();
        }

        public string XmlEnv()
        {
            return XmlEnvio.OuterXml;
        }
        public string XmlRet()
        {
            return wsSer.nfeStatusServicoNF2(XmlEnvio).OuterXml;
        }

    }
}

