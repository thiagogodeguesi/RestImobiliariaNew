using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestImobiliaria.Models
{
    public class Status
    {
        private int id;
        private string nome;
        private int ativo;
        private int statusimovel;
        private int statuscliente;
        private int statusmacth;
        private int statuscorretor;

        public Status() { }

        public Status(int id, string nome, int ativo, int statusimovel, int statuscliente, int statusmacth, int statuscorretor)
        {
            this.Id = id;
            this.Nome = nome;
            this.Ativo = ativo;
            this.StatusImovel = statusimovel;
            this.StatusCliente = statuscliente;
            this.StatusMacth = statusmacth;
            this.StatusCorretor = statuscorretor;
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

        public int Ativo
        {
            get
            { return ativo; }
            set
            { ativo = value; }
        }
        public int StatusImovel
        {
            get
            { return statusimovel; }
            set
            { statusimovel = value; }
        }
        public int StatusCliente
        {
            get
            { return statuscliente; }
            set
            { statuscliente = value; }
        }
        public int StatusMacth
        {
            get
            { return statusmacth; }
            set
            { statusmacth = value; }
        }
        public int StatusCorretor
        {
            get
            { return statuscorretor; }
            set
            { statuscorretor = value; }
        }

    }
}