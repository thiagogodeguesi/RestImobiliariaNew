using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

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
            return 1;
        }
        public int AlteraCorretor(int xid, Corretor fCorretor)
        {
            return 2;
        }
        public List<Corretor> listaCorretores()
        {
            List<Corretor> lCorretores = new List<Corretor>();
            return lCorretores;
        }
        public Corretor oCorretor (int xID)
        {
            Corretor xoCorretor = new Corretor();
            return xoCorretor;
        }
    }
}