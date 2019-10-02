﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locacao.Model
{
    public class Livro
    {
        public Livro(string Titulo, bool Disponivel = true)
        {
            this.Disponivel = Disponivel;
            this.Titulo = Titulo;
        }

        public Livro(int cod, string Titulo, bool Disponivel = true)
        {
            this.CodLivro = cod;
            this.Disponivel = Disponivel;
            this.Titulo = Titulo;
        }


        public int CodLivro { get; set; }
        public string Titulo { get; set; }
        public bool Disponivel { get; set; }

        public override string ToString()
        {
            return $"Titulo: {Titulo}\nCodigo: {CodLivro}\nDisponibilidade: {Disponivel}";
        }
    }
}