using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestImobiliaria.Models
{
    public class Cadastros
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

            public Status() {}

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
                { return ativo; }
                set
                { ativo = value; }
            }
            public int StatusCliente
            {
                get
                { return ativo; }
                set
                { ativo = value; }
            }
            public int StatusMacth
            {
                get
                { return ativo; }
                set
                { ativo = value; }
            }
            public int StatusCorretor
            {
                get
                { return ativo; }
                set
                { ativo = value; }
            }

        }

        public class Dormitorios
        {
            private int id;
            private string nome;
            private int ativo;


            public Dormitorios() { }

            public Dormitorios(int id, string nome, int ativo)
            {
                this.Id = id;
                this.Nome = nome;
                this.Ativo = ativo;
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
        }
        public class EstagioObra
        {
            private int id;
            private string nome;
            private int ativo;


            public EstagioObra() { }

            public EstagioObra(int id, string nome, int ativo)
            {
                this.Id = id;
                this.Nome = nome;
                this.Ativo = ativo;
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
        }
        public class FaixaPreco
        {
            private int id;
            private string nome;
            private int ativo;


            public FaixaPreco() { }

            public FaixaPreco(int id, string nome, int ativo)
            {
                this.Id = id;
                this.Nome = nome;
                this.Ativo = ativo;
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
        }
        public class Metragem
        {
            private int id;
            private string nome;
            private int ativo;


            public Metragem() { }

            public Metragem(int id, string nome, int ativo)
            {
                this.Id = id;
                this.Nome = nome;
                this.Ativo = ativo;
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
        }
        public class Operacao
        {
            private int id;
            private string nome;
            private int ativo;


            public Operacao() { }

            public Operacao(int id, string nome, int ativo)
            {
                this.Id = id;
                this.Nome = nome;
                this.Ativo = ativo;
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
        }
        public class TpImovel
        {
            private int id;
            private string nome;
            private int ativo;


            public TpImovel() { }

            public TpImovel(int id, string nome, int ativo)
            {
                this.Id = id;
                this.Nome = nome;
                this.Ativo = ativo;
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
        }
        public class TpOperacao
        {
            private int id;
            private string nome;
            private int ativo;


            public TpOperacao() { }

            public TpOperacao(int id, string nome, int ativo)
            {
                this.Id = id;
                this.Nome = nome;
                this.Ativo = ativo;
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
        }
        public class Uf
        {
            private int id;
            private string nome;
            private int ativo;


            public Uf() { }

            public Uf(int id, string nome, int ativo)
            {
                this.Id = id;
                this.Nome = nome;
                this.Ativo = ativo;
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
        }
        public class Vagas
        {
            private int id;
            private string nome;
            private int ativo;


            public Vagas() { }

            public Vagas(int id, string nome, int ativo)
            {
                this.Id = id;
                this.Nome = nome;
                this.Ativo = ativo;
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
        }
        public class ZonaCidade
        {
            private int id;
            private string nome;
            private int ativo;


            public ZonaCidade() { }

            public ZonaCidade(int id, string nome, int ativo)
            {
                this.Id = id;
                this.Nome = nome;
                this.Ativo = ativo;
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
        }
    }
}