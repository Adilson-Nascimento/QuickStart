﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuickStart.Dominio.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }

        public string Nome { get; set; }

        public string SobreNome { get; set; }

        ///<summary>
        /// Um usuário poder ter nenhum ou muitos pedidos
        ///</summary>
        public ICollection<Pedido> Pedidos { get; set; }

    }
}
