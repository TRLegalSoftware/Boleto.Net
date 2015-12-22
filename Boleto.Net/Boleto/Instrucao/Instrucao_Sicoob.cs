using System;

namespace BoletoNet
{
    public class Instrucao_Sicoob : AbstractInstrucao, IInstrucao
    {

        #region Construtores

        public Instrucao_Sicoob()
        {
            try
            {
                this.Banco = new Banco(756);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao carregar objeto", ex);
            }
        }

        public Instrucao_Sicoob(int codigo)
        {
            //this.carregar(codigo, 0, 0);
        }

        public Instrucao_Sicoob(int codigo, int nrDias)
        {
            //this.carregar(codigo, nrDias, (double)0.0);
        }

        public Instrucao_Sicoob(int codigo, double percentualMultaDia)
        {
            //this.carregar(codigo, 0, percentualMultaDia);
        }

        public Instrucao_Sicoob(int codigo, int nrDias, double percentualMultaDia)
        {
            //this.carregar(codigo, nrDias, percentualMultaDia);
        }

        #endregion

        #region Metodos Privados

        //private void carregar(int idInstrucao, int nrDias, double percentualMultaDia)
        //{
        //    try
        //    {
        //        this.Banco = new Banco_Banrisul();
        //        this.Valida();

        //        switch ((EnumInstrucoes_Banrisul)idInstrucao)
        //        {
        //            case EnumInstrucoes_Banrisul.NaoDispensarComissaoPermanencia:
        //                this.Codigo = (int)EnumInstrucoes_Banrisul.NaoDispensarComissaoPermanencia;
        //                this.Descricao = "N�o dispensar comiss�o de perman�ncia"; //01
        //                break;
        //            case EnumInstrucoes_Banrisul.NaoCobrarComissaoPermanencia:
        //                this.Codigo = (int)EnumInstrucoes_Banrisul.NaoCobrarComissaoPermanencia;
        //                this.Descricao = "N�o cobrar comiss�o de perman�ncia"; //08
        //                break;
        //            case EnumInstrucoes_Banrisul.Protestar:
        //                this.Codigo = (int)EnumInstrucoes_Banrisul.Protestar;
        //                this.Descricao = "Protestar caso impago " + nrDias + " dias ap�s vencimento"; //09
        //                break;
        //            case EnumInstrucoes_Banrisul.DevolverAposNDias:
        //                this.Codigo = (int)EnumInstrucoes_Banrisul.DevolverAposNDias;
        //                this.Descricao = "Devolver se impago ap�s " + nrDias + " dias do vencimento"; //15
        //                break;
        //            case EnumInstrucoes_Banrisul.CobrarMultaAposNDias:
        //                this.Codigo = (int)EnumInstrucoes_Banrisul.CobrarMultaAposNDias;
        //                this.Descricao = "Ap�s " + nrDias + " dias do vencimento, cobrar " + percentualMultaDia + "% de multa"; //18
        //                break;
        //            case EnumInstrucoes_Banrisul.CobrarMultaOuFracaoAposNDias:
        //                this.Codigo = (int)EnumInstrucoes_Banrisul.CobrarMultaOuFracaoAposNDias;
        //                this.Descricao = "Ap�s " + nrDias + " dias do vencimento, cobrar " + percentualMultaDia + "% de multa ao m�s ou fra��o"; //20
        //                break;
        //            case EnumInstrucoes_Banrisul.NaoProtestar:
        //                this.Codigo = (int)EnumInstrucoes_Banrisul.NaoProtestar;
        //                this.Descricao = "N�o protestar"; //23
        //                break;
        //            default:
        //                this.Codigo = 0;
        //                this.Descricao = "( Selecione )";
        //                break;
        //        }

        //        this.QuantidadeDias = nrDias;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Erro ao carregar objeto", ex);
        //    }
        //}

        public override void Valida()
        {
            //base.Valida();
        }

        #endregion

    }
}