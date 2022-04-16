﻿using NerdStore.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Domain
{
    public class Categoria : Entity
    {
        public string Nome { get; private set; }
        public int Codigo { get; private set; }
        private IList<Produto> _produtos { get; set; }

        public IReadOnlyCollection<Produto> Produtos => _produtos.ToList();

        protected Categoria()
        {
            _produtos = new List<Produto>();
        }
        public Categoria(string nome, int codigo)
        {
            Nome = nome;
            Codigo = codigo;
            Validar();
        }


        public override string ToString()
        {
            return $"{Nome} - {Codigo}";
        }

        public void Validar()
        {
            Validacoes.ValidarSeVazio(Nome, "O campo Nome da categoria não pode estar vazio");
            Validacoes.ValidarSeIgual(Codigo, 0, "O campo Codigo não pode ser 0");
        }
    }
}
