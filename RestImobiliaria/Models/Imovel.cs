using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestImobiliaria.Models
{
    public class Imovel
    {
        private int id;
        private int id_corretor;
        private int id_operacao;
        private int id_tp_imovel;
        private int id_metragem;
        private int id_dormitorio;
        private int id_vaga;
        private int id_estagio;
        private int id_faixa_valor;
        private int id_status;
        private int id_zona;
        private int id_uf;
        private string nome;
        private int ativo;
        private DateTime data;
        private string dp_vendas;
        private string data_lancamento;
        private string bairro;
        private string cidade;
        private string endereco;
        private string detalhes;
        private string suites;
        private string comissao;
        private string inf_imovel;
        private string inf_vendedor;
        private string condominio;
        private string iptu;
        private string idade_emp;
        private DateTime alteracao;

        public Imovel()
        {
        }

        public Imovel(int id, string nome)
        {
            this.Id = id;
            this.Id_corretor = id_corretor;
            this.Id_operacao = id_operacao;
            this.Id_tp_imovel = id_tp_imovel;
            this.Id_metragem = id_metragem;
            this.Id_dormitorio = id_dormitorio;
            this.Id_vaga = id_vaga;
            this.Id_estagio = id_estagio;
            this.Id_faixa_valor = id_faixa_valor;
            this.Id_status = id_status;
            this.Id_zona = id_zona;
            this.Id_uf = id_uf;
            this.Nome = nome;
            this.Ativo = ativo;
            this.Data = data;
            this.Dp_vendas = dp_vendas;
            this.Data_lancamento = data_lancamento;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Endereco = endereco;
            this.Detalhes = detalhes;
            this.Suites = suites;
            this.Comissao = comissao;
            this.Inf_imovel = inf_imovel;
            this.Inf_vendedor = inf_vendedor;
            this.Condominio = condominio;
            this.Iptu = iptu;
            this.Idade_emp = idade_emp;
            this.Alteracao = alteracao;

        }

        public int Id
        {
            get
            { return id; }
            set
            { id = value; }
        }
        public int Id_corretor
        {
            get
            { return id_corretor; }
            set
            { id_corretor = value; }
        }

        public int Id_operacao
        {
            get
            { return id_operacao; }
            set
            { id_operacao = value; }
        }
        public int Id_tp_imovel
        {
            get
            { return id_tp_imovel; }
            set
            { id_tp_imovel = value; }
        }
        public int Id_metragem
        {
            get
            { return id_metragem; }
            set
            { id_metragem = value; }
        }
        public int Id_dormitorio
        {
            get
            { return id_dormitorio; }
            set
            { id_dormitorio = value; }
        }
        public int Id_vaga
        {
            get
            { return id_vaga; }
            set
            { id_vaga = value; }
        }
        public int Id_estagio
        {
            get
            { return id_estagio; }
            set
            { id_estagio = value; }
        }
        public int Id_faixa_valor
        {
            get
            { return id_faixa_valor; }
            set
            { id_faixa_valor = value; }
        }
        public int Id_status
        {
            get
            { return id_status; }
            set
            { id_status = value; }
        }
        public int Id_zona
        {
            get
            { return id_zona; }
            set
            { id_zona = value; }
        }
        public int Id_uf
        {
            get
            { return id_uf; }
            set
            { id_uf = value; }
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
        public DateTime Data
        {
            get
            { return data; }
            set
            { data = value; }
        }
        public string Dp_vendas
        {
            get
            { return dp_vendas; }
            set
            { dp_vendas = value; }
        }
        public string Data_lancamento
        {
            get
            { return data_lancamento; }
            set
            { data_lancamento = value; }
        }
        public string Bairro
        {
            get
            { return bairro; }
            set
            { bairro = value; }
        }
        public string Cidade
        {
            get
            { return cidade; }
            set
            { cidade = value; }
        }
        public string Endereco
        {
            get
            { return endereco; }
            set
            { endereco = value; }
        }
        public string Detalhes
        {
            get
            { return detalhes; }
            set
            { detalhes = value; }
        }
        public string Suites
        {
            get
            { return suites; }
            set
            { suites = value; }
        }
        public string Comissao
        {
            get
            { return comissao; }
            set
            { comissao = value; }
        }
        public string Inf_imovel
        {
            get
            { return inf_imovel; }
            set
            { inf_imovel = value; }
        }


        public string Inf_vendedor
        {
            get
            { return inf_vendedor; }
            set
            { inf_vendedor = value; }
        }
        public string Condominio
        {
            get
            { return condominio; }
            set
            { condominio = value; }
        }
        public string Iptu
        {
            get
            { return iptu; }
            set
            { iptu = value; }
        }
        public string Idade_emp
        {
            get
            { return idade_emp; }
            set
            { Idade_emp = value; }
        }
        public DateTime Alteracao
        {
            get
            { return alteracao; }
            set
            { alteracao = value; }
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
        public Corretor oCorretor(int xID)
        {
            Corretor xoCorretor = new Corretor();
            return xoCorretor;
        }
    
}
}