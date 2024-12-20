﻿using Core._3_Entidade.DTOs;
using Core.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core._2_Repository.Interface
{
    public interface ICaminhaoRepository
    {
        long AdicionarCaminhao(CreateCaminhaoDTO caminhao);
        List<Caminhao> ListarCaminhao();
        void EditarCaminhao(Caminhao caminhao);
        void DeletarCaminhao(int id);
        Caminhao BuscarPorId(int id);
    }
}
