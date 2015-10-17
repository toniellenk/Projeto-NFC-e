﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Projeto_NFC_e
{
    public class DadosProdutos
    {
       public class ProdObj 
       {
        public string Nome;
        public string Desc;
        public string CodBarras;
        public int Ncm;
        public int  UnMed;
        public char CstIcms;
        public string TipTribIcms;
        public char AliqIcms;
        public string CstIpi;
        public char AliqIpi;
        public string CstPis;
        public char AliqPis;
        public string CstCofins;
        public char AliqCofins;
        public string Deposito;
        public string LocDepos;
        public string SubLocDepos;
        public string Fornecedor;
        public string Vendedor;
        public string GrupItens;
       }
        
        string SrtCon = ConfigurationManager.ConnectionStrings["root"].ConnectionString;
        public DataSet ds = new DataSet();
        public DataTable dt = new DataTable();

        public DataTable Consulta() { 
            
                string SqlSelect = "select * from t0040";
                /*Cria o objeto de conexão com o banco */
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                /*Cria o objeto de execução do comando */
                SqlCommand ObjCmd = new SqlCommand(SqlSelect, ObjConn);
                ObjConn.Open();   
                /*Executa o comando*/
                SqlDataAdapter da = new SqlDataAdapter(ObjCmd);
                /*Abre a conexão */
                da.Fill(ds);
                dt = ds.Tables[0];
                ObjConn.Close();
                return dt;
        }


        public DataTable Consulta(int IdProd)
        {

                /*Query SQL*/    
                string SqlSelect = "select * from t0040 where IdProd = @IdProd";
               
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                SqlCommand ObjCmd = new SqlCommand(SqlSelect, ObjConn);
                
                /*Definição de parãmetros da Query */
                ObjCmd.Parameters.AddWithValue("@IdProd", IdProd);
                
                ObjConn.Open();   
                SqlDataAdapter da = new SqlDataAdapter(ObjCmd);
                da.Fill(ds);
                dt = ds.Tables[0];
                ObjConn.Close();
                return dt;
        }
        
        public void inserir(ProdObj Prod)
            {
                string SqlInsert = "insert into t0040 values(Nome@, @DescDet, @CodBarras, @Ncm, @UnMed, ";
                SqlInsert += "@CstIcms, TipTribIcms, @AliqIcms, @CstIpi, @AliqIpi, @CstPis, @AliqPis, @CstCofins, @AliqCofins, ";
                SqlInsert += "@Deposito, @LocDepos, @SubLocDepos, @Fornecedor, @Vendedor, @GrupItens)";
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                SqlCommand ObjCmd = new SqlCommand(SqlInsert, ObjConn);

                ObjCmd.Parameters.AddWithValue("Nome@", Prod.Nome);
                ObjCmd.Parameters.AddWithValue("@Desc", Prod.Desc);
                ObjCmd.Parameters.AddWithValue("@CodBarras", Prod.CodBarras);
                ObjCmd.Parameters.AddWithValue("@Ncm", Prod.Ncm);
                ObjCmd.Parameters.AddWithValue("@UnMed", Prod.UnMed);
                ObjCmd.Parameters.AddWithValue("@CstIcms", Prod.CstIcms);
                ObjCmd.Parameters.AddWithValue("@TipTribIcms", Prod.TipTribIcms);
                ObjCmd.Parameters.AddWithValue("@AliqIcms", Prod.AliqIcms);
                ObjCmd.Parameters.AddWithValue("@CstIpi", Prod.CstIpi);
                ObjCmd.Parameters.AddWithValue("@AliqIpi", Prod.AliqIpi);
                ObjCmd.Parameters.AddWithValue("@CstPis", Prod.CstPis);
                ObjCmd.Parameters.AddWithValue("@AliqPis", Prod.AliqPis);
                ObjCmd.Parameters.AddWithValue("@CstCofins", Prod.CstCofins);
                ObjCmd.Parameters.AddWithValue("@AliqCofins", Prod.AliqCofins);
                ObjCmd.Parameters.AddWithValue("@Deposito", Prod.Deposito);
                ObjCmd.Parameters.AddWithValue("@LocDepos", Prod.LocDepos);
                ObjCmd.Parameters.AddWithValue("@SubLocDepos", Prod.SubLocDepos);
                ObjCmd.Parameters.AddWithValue("@Fornecedor", Prod.Fornecedor);
                ObjCmd.Parameters.AddWithValue("@Vendedor", Prod.Vendedor);
                ObjCmd.Parameters.AddWithValue("@GrupItens", Prod.GrupItens);
                
                ObjConn.Open();
                
                ObjCmd.ExecuteNonQuery();
                
                ObjConn.Close();
            }

        public void atualizar(ProdObj Prod, string IdProd)
            {
                string SqlUpdate = "update t0025 set ";
                
                SqlUpdate += "Nome = @Nome, ";
                SqlUpdate += "Nome = @Desc, ";
                SqlUpdate += "CpfCnpj = @CodBarras, ";
                SqlUpdate += "Pessoa = @Pessoa, "; 
                SqlUpdate += "Estrangeiro = @Ncm, ";
                SqlUpdate += "RS = @UnMed, ";
                SqlUpdate += "NomeFant = CstIcms,"; 
                SqlUpdate += "Endereco = @TipTribIcms, ";
                SqlUpdate += "Num = @AliqIcms, ";
                SqlUpdate += "Cep = @CstIpi, ";
                SqlUpdate += "FoneRes = @AliqIpi, ";
                SqlUpdate += "FoneCom = @CstPis, ";
                SqlUpdate += "Cel = @AliqPis, ";
                SqlUpdate += "OutrosCont = @CstCofins, ";
                SqlUpdate += "Email = @AliqCofins, ";
                SqlUpdate += "IdentFiscal = @Deposito, ";
                SqlUpdate += "InscEst = @LocDepos, ";
                SqlUpdate += "Fornecedor = @Fornecedor "; 
                SqlUpdate += "Vendedor = @Vendedor "; 
                SqlUpdate += "GrupItens = @GrupItens "; 
                
                SqlUpdate += "where IdProd = @IdProd";
                
                SqlConnection ObjConn = new SqlConnection(SrtCon);
                SqlCommand ObjCmd = new SqlCommand(SqlUpdate, ObjConn);

                ObjCmd.Parameters.AddWithValue("@Nome", Prod.Nome);
                ObjCmd.Parameters.AddWithValue("@Desc", Prod.Desc);
                ObjCmd.Parameters.AddWithValue("@CodBarras", Prod.CodBarras);
                ObjCmd.Parameters.AddWithValue("@Ncm", Prod.Ncm);
                ObjCmd.Parameters.AddWithValue("@UnMed", Prod.UnMed);
                ObjCmd.Parameters.AddWithValue("@CstIcms", Prod.CstIcms);
                ObjCmd.Parameters.AddWithValue("@TipTribIcms", Prod.TipTribIcms);
                ObjCmd.Parameters.AddWithValue("@AliqIcms", Prod.AliqIcms);
                ObjCmd.Parameters.AddWithValue("@CstIpi", Prod.CstIpi);
                ObjCmd.Parameters.AddWithValue("@AliqIpi", Prod.AliqIpi);
                ObjCmd.Parameters.AddWithValue("@CstPis", Prod.CstPis);
                ObjCmd.Parameters.AddWithValue("@AliqPis", Prod.AliqPis);
                ObjCmd.Parameters.AddWithValue("@CstCofins", Prod.CstCofins);
                ObjCmd.Parameters.AddWithValue("@AliqCofins", Prod.AliqCofins);
                ObjCmd.Parameters.AddWithValue("@Deposito", Prod.Deposito);
                ObjCmd.Parameters.AddWithValue("@LocDepos", Prod.LocDepos);
                ObjCmd.Parameters.AddWithValue("@SubLocDepos", Prod.SubLocDepos);
                ObjCmd.Parameters.AddWithValue("@Fornecedor", Prod.Fornecedor);
                ObjCmd.Parameters.AddWithValue("@Vendedor", Prod.Vendedor);
                ObjCmd.Parameters.AddWithValue("@GrupItens", Prod.GrupItens);
                ObjCmd.Parameters.AddWithValue("IdProd@", IdProd);
                
                ObjConn.Open();
                
                ObjCmd.ExecuteNonQuery();
                
                ObjConn.Close();
            }
        
        public string nome {
            get { return SrtCon; }
        }
    }
}
