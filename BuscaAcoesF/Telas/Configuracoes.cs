﻿using AutoMapper;
using BuscaAcoes.Dominio.Auxiliar;
using BuscaAcoes.Dominio.Dtos;
using BuscaAcoes.Dominio.Entidades;
using BuscaAcoes.Dominio.Interfaces.Servicos;
using BuscaAcoesF.Formularios.Estilo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaAcoesF.Telas
{
    public partial class Configuracoes : FormBase
    {
        private readonly IMapper _mapper;
        private readonly IServicoConfiguracao _servicoConfiguracao;
        private readonly ConfiguracoesSistema _configuracacoesSistema;
        public Configuracoes(IMapper mapper,
            IServicoConfiguracao servicoConfiguracao,
            ConfiguracoesSistema configuracacoesSistema)
            : base(configuracacoesSistema)
        {
            InitializeComponent();
            FormatarTela(this);
            TopMost = true;

            _mapper = mapper;
            _servicoConfiguracao = servicoConfiguracao;
            _configuracacoesSistema = configuracacoesSistema;
        }

        private async void btnAplicar_Click(object sender, EventArgs e)
        {
            var configuracao = await ValidarDadosConfiguracao();

            if (!configuracao.Resultado) return;

            await _servicoConfiguracao.Atualizar(configuracao.Configuracao);

            _configuracacoesSistema.Config = configuracao.Configuracao;

            this.Close();
        }

        private async Task<(Configuracao Configuracao, Boolean Resultado)> ValidarDadosConfiguracao()
        {
            var configuracoes = new ConfiguracaoDto(ckbModoDesenvolvimento.Checked,
                   Convert.ToInt32(numTempoAtualizacaoDados.Value),
                   txtNomeUsuario.Text,
                   txtMensagemErroOrigem.Text,
                   txtHoraInicioMonitoramento.Text,
                   txtHoraFimMonitoramento.Text,
                   Convert.ToInt32(txtPorcentagemVariacao.Text),
                   Convert.ToDecimal(txtValorCorretagem.Text));

            if (!configuracoes.Valido)
                MessageBox.Show(configuracoes.Notificacoes.Aggregate((A, B) => A + "," + B), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);


            return await Task.FromResult((_mapper.Map<Configuracao>(configuracoes), !configuracoes.Notificacoes.Any()));
        }

        private async void Configuracoes_Load(object sender, EventArgs e)
        {
            PreencherDados(_configuracacoesSistema.Config);
        }

        private void PreencherDados(Configuracao configuracao)
        {
            if (configuracao == null) return;
            ckbModoDesenvolvimento.Checked = configuracao.ModoDesenvolvimento;
            numTempoAtualizacaoDados.Value = configuracao.TempoAtualizacaoDados;
            txtNomeUsuario.Text = configuracao.NomeUsuario;
            txtMensagemErroOrigem.Text = configuracao.MensagemErroOrigem;
            txtHoraInicioMonitoramento.Text = configuracao.HoraInicioAtualizacaoDados;
            txtHoraFimMonitoramento.Text = configuracao.HoraFimAtualizacaoDados;
            txtPorcentagemVariacao.Value = configuracao.PorcentagemVariavao;
            txtValorCorretagem.Text = Convert.ToString(configuracao.ValorCorretagem);
        }
    }
}
