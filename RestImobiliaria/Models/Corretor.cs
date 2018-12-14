using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using MySql.Data.MySqlClient;

namespace RestImobiliaria.Models
{
    public class Corretor
    {
        private int id;
        private string nome;
        private string cpf;
        private string creci;
        private string ufcreci;
        private string telefone;
        private string email;
        private int visivel;
        private string senha;
 

        public Corretor()
        {
        }

        public Corretor(int id, string nome, string cpf, string creci, string ufcreci, string telefone, string email, string senha, int visivel)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf = cpf;
            this.Creci = creci;
            this.Ufcreci = ufcreci;
            this.Telefone = telefone;
            this.Email = email;
            this.Visivel = visivel;
            this.Senha = senha;
        }

        public int Id
        {
            get
            { return id; }
            set
            { id = value; }
        }

        public string Nome
        {
            get
            { return nome; }
            set
            { nome = value; }
        }

        
        public string Cpf {
            get
            { return cpf; }
            set
            { cpf = value; }
        }

        public string Creci {
            get
            { return creci; }
            set
            { creci = value; }
        }

        public string Ufcreci {
            get
            { return ufcreci; }
            set
            { ufcreci = value; }
        }

        public string Telefone{
            get
            { return telefone; }
            set
            { telefone = value; }
        }

        public string Email
        {
            get
            { return email; }
            set
            { email = value; }
        }

        public int Visivel
        {
            get
            { return visivel; }
            set
            { visivel = value; }
        }

        public string Senha 
        {
            get
            { return senha; }
            set
            { senha = value; }
        }
        
        
        public int NovoCorretor(Corretor fCorretor)
        {
            try
            {
                int vRet = new Corretor().insCorretor(fCorretor);
                return vRet;
            }
            catch { return 0; }
        }
        public int AlteraCorretor(int xid, Corretor fCorretor)
        {
            try
            { 
                int vRet = new Corretor().atuCorretor(xid, fCorretor);
                return vRet;
            }
            catch { return 0; }
        }
        public List<Corretor> listaCorretores()
        {
            List<Corretor> lCorretores = new List<Corretor>();
            lCorretores = new Corretor().busaCorretores();
            return lCorretores;
        }
        public Corretor oCorretor (int xID)
        {
            Corretor xoCorretor = new Corretor().busaCorretor(xID);
            return xoCorretor;
        }

        public bool loginCorretor (string xEmail, string xSenha, out Corretor rCorretor)
        {
            Corretor nCorretor = new Corretor();
            if (xEmail != "" || xSenha != "")
            {
                nCorretor = nCorretor.busaCorretor(xEmail, xSenha);

                if (nCorretor.Id != 0)
                {
                    rCorretor = nCorretor;
                    return true;
                }
            }

            rCorretor = nCorretor;
            return false;
        }

        public Corretor busaCorretor (string xEmail, string xSenha)
        {
            Corretor lgnCorretor = new Corretor();
            //---
            try
            {
                using (MySqlConnection conn = new MySqlConnection("Persist Security info = False; server = mysql08-farm76.kinghost.net; database   = rastreiaminhae; uid = rastreiaminhae; pwd = Godeguesi18"))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM CORRETOR WHERE EMAIL = '" + xEmail + "' AND SENHA =  '" + xSenha + "'", conn))
                    {
                        try
                        {
                            MySqlDataReader MSDataReder = cmd.ExecuteReader();
                            while (MSDataReder.Read())
                            {
                                lgnCorretor.Id = Convert.ToInt32(MSDataReder["ID"].ToString());
                                lgnCorretor.Nome = MSDataReder["NOME"].ToString();
                                lgnCorretor.Cpf = MSDataReder["CPF"].ToString();
                                lgnCorretor.Creci = MSDataReder["CRECI"].ToString();
                                lgnCorretor.Ufcreci = MSDataReder["UF_CRECI"].ToString();
                                lgnCorretor.Telefone = MSDataReder["TELEFONE"].ToString();
                                lgnCorretor.Email = MSDataReder["EMAIL"].ToString();
                                lgnCorretor.Visivel = Convert.ToInt32(MSDataReder["VISIVEL"].ToString());
                                lgnCorretor.Senha = MSDataReder["SENHA"].ToString();
                            }
                        }
                        catch (Exception errox)
                        {
                            conn.Close();
                            lgnCorretor.Id = 0;
                        }
                    }
                }
            }
            catch { lgnCorretor.Id = 0; }
            return lgnCorretor;
        }

        public Corretor busaCorretor(int xID)
        {
            Corretor lgnCorretor = new Corretor();
            //---
            try
            {
                using (MySqlConnection conn = new MySqlConnection("Persist Security info = False; server = mysql08-farm76.kinghost.net; database   = rastreiaminhae; uid = rastreiaminhae; pwd = Godeguesi18"))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM CORRETOR WHERE ID = '" + xID + "'", conn))
                    {
                        try
                        {
                            MySqlDataReader MSDataReder = cmd.ExecuteReader();
                            while (MSDataReder.Read())
                            {
                                lgnCorretor.Id = Convert.ToInt32(MSDataReder["ID"].ToString());
                                lgnCorretor.Nome = MSDataReder["NOME"].ToString();
                                lgnCorretor.Cpf = MSDataReder["CPF"].ToString();
                                lgnCorretor.Creci = MSDataReder["CRECI"].ToString();
                                lgnCorretor.Ufcreci = MSDataReder["UF_CRECI"].ToString();
                                lgnCorretor.Telefone = MSDataReder["TELEFONE"].ToString();
                                lgnCorretor.Email = MSDataReder["EMAIL"].ToString();
                                lgnCorretor.Visivel = Convert.ToInt32(MSDataReder["VISIVEL"].ToString());
                                lgnCorretor.Senha = MSDataReder["SENHA"].ToString();
                            }
                        }
                        catch (Exception errox)
                        {
                            conn.Close();
                            lgnCorretor.Id = 0;
                        }
                    }
                }
            }
            catch { lgnCorretor.Id = 0; }
            return lgnCorretor;
        }

        public List<Corretor> busaCorretores()
        {
            List<Corretor> listCorretor = new List<Corretor>();
            Corretor nCorretor = new Corretor();
            //---
            try
            {
                using (MySqlConnection conn = new MySqlConnection("Persist Security info = False; server = mysql08-farm76.kinghost.net; database   = rastreiaminhae; uid = rastreiaminhae; pwd = Godeguesi18"))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM CORRETOR " , conn))
                    {
                        try
                        {
                            MySqlDataReader MSDataReder = cmd.ExecuteReader();
                            while (MSDataReder.Read())
                            {
                                nCorretor.Id = Convert.ToInt32(MSDataReder["ID"].ToString());
                                nCorretor.Nome = MSDataReder["NOME"].ToString();
                                nCorretor.Cpf = MSDataReder["CPF"].ToString();
                                nCorretor.Creci = MSDataReder["CRECI"].ToString();
                                nCorretor.Ufcreci = MSDataReder["UF_CRECI"].ToString();
                                nCorretor.Telefone = MSDataReder["TELEFONE"].ToString();
                                nCorretor.Email = MSDataReder["EMAIL"].ToString();
                                nCorretor.Visivel = Convert.ToInt32(MSDataReder["VISIVEL"].ToString());
                                nCorretor.Senha = MSDataReder["SENHA"].ToString();

                                listCorretor.Add(nCorretor);
                            }
                        }
                        catch (Exception errox)
                        {
                            conn.Close();
                        }
                    }
                }
            }
            catch { }
            return listCorretor;
        }

        public int atuCorretor(int xId, Corretor xCorreor)
        {
            if (xId != xCorreor.id)
            {
                return 0;
            }
            //---
            try
            {
                using (MySqlConnection conn = new MySqlConnection("Persist Security info = False; server = mysql08-farm76.kinghost.net; database   = rastreiaminhae; uid = rastreiaminhae; pwd = Godeguesi18"))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(" UPDATE CORRETOR SET "
                                                              + " NOME      = '" + xCorreor.Nome + "'"
                                                              + " CPF       = '" + xCorreor.Cpf + "'"
                                                              + " CRECI     = '" + xCorreor.Cpf + "'"
                                                              + " UF_CRECI  = '" + xCorreor.Creci + "'"
                                                              + " TELEFONE  = '" + xCorreor.Telefone + "'"
                                                              //+ " EMAIL     = '" + xCorreor.Email + "'"
                                                              + " VISIVEL   = '" + xCorreor.Visivel + "'"
                                                              + " SENHA     = '" + xCorreor.Senha + "'"
                                                              + " WHERE ID  = '" + xId + "'"
                                                               , conn))
                    {
                        try
                        {
                            cmd.ExecuteScalar();
                            return 1;
                        }
                        catch (Exception errox)
                        {
                            conn.Close();
                            return 0;
                        }
                    }
                }
            }
            catch { return 0; }
        }

        public int insCorretor(Corretor xCorreor)
        {
            //---
            try
            {
                using (MySqlConnection conn = new MySqlConnection("Persist Security info = False; server = mysql08-farm76.kinghost.net; database   = rastreiaminhae; uid = rastreiaminhae; pwd = Godeguesi18"))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(" INSERT INTO CORRETOR (ID ,NOME ,CPF ,CRECI ,UF_CRECI ,TELEFONE ,EMAIL ,VISIVEL, SENHA) VALUES ( "
                                                              + " '" + xCorreor.Id + "'"
                                                              + " '" + xCorreor.Nome + "'"
                                                              + " '" + xCorreor.Cpf + "'"
                                                              + " '" + xCorreor.Cpf + "'"
                                                              + " '" + xCorreor.Creci + "'"
                                                              + " '" + xCorreor.Telefone + "'"
                                                              + "'" + xCorreor.Email + "'"
                                                              + "'" + xCorreor.Visivel + "'"
                                                              + "'" + xCorreor.Senha + "'"
                                                              + ")" , conn))
                    {
                        try
                        {
                            cmd.ExecuteScalar();
                            return 1;
                        }
                        catch (Exception errox)
                        {
                            conn.Close();
                            return 0;
                        }
                    }
                }
            }
            catch { return 0; }
        }
    }
}