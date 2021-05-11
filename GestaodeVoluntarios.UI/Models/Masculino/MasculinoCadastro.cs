﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GestaodeVoluntarios.UI.Models.Masculino
{
    public class MasculinoCadastro : EntidadeBasica
    {
        public int MasculinoCadastroId { get; set; }
        public string CadastroDataInclusao { get; set; }
        public string CadastroNome { get; set; }
        public string CadastroRG { get; set; }
        public string CadastroClasseSocial { get; set; }
        public string CadastroObsGerais { get; set; }
        public string CadastroObs1 { get; set; }
        public string CadastroObs2 { get; set; }
        public string CadastroObs3 { get; set; }
        public string CadastroDataNascimento { get; set; }
        public int? CadastroIdade { get; set; }
        public string DataCadastro { get; set; }
        public string CPF { get; set; }
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public string EnsinoFundamentalCompleto { get; set; }
        public string EnsinoMedioCompleto { get; set; }
        public string EnsinoSuperiorCompleto { get; set; }
        public string EnsinoPosGraduacaoCompleta { get; set; }        
        public string NomeDaEmpresa { get; set; }
        public string Profissao { get; set; }
        public string TelefoneResidencial { get; set; }
        public string TelefoneCelular { get; set; }
        public string Whatsapp { get; set; }
        public string TelefoneComercialRecado { get; set; }      
        public string CapacidadeSentirCheiroNormal { get; set; }
        public string Diabetico { get; set; }
        public string Fumante { get; set; }
        public string Alergia { get; set; }
        public string AlergiaQual { get; set; }
        public string FilhosSexo1 { get; set; }
        public string FilhosDataNascimento1 { get; set; }
        public string FilhosSexo2 { get; set; }
        public string FilhosDataNascimento2 { get; set; }
        public string FilhosSexo3 { get; set; }
        public string FilhosDataNascimento3 { get; set; }
        public string FilhosSexo4 { get; set; }
        public string FilhosDataNascimento4 { get; set; }
        public string FilhosSexo5 { get; set; }
        public string FilhosDataNascimento5 { get; set; }
        public string FilhosSexo6 { get; set; }
        public string FilhosDataNascimento6 { get; set; }
        public bool SaboneteCorporalBarra { get; set; }
        public bool SaboneteCorporalLiquido { get; set; }
        public bool SaboneteFacialBarra { get; set; }
        public bool SaboneteFacialLiquido { get; set; }
        public bool SaboneteFacialEsfoliante { get; set; }
        public bool SaboneteFacialGel { get; set; }
        public bool SaboneteFacialEspuma { get; set; }
        public bool HigieneBucalCremeDental { get; set; }
        public bool HigieneBucalEscovaDental { get; set; }
        public bool HigieneBucalFioDental { get; set; }
        public bool HigieneBucalEnxaguanteBucal { get; set; }
        public bool DesodoranteCorporalAerosol { get; set; }
        public bool DesodoranteCreme { get; set; }
        public bool DesodoranteRollon { get; set; }
        public bool DesodoranteSpray { get; set; }
        public bool HidratanteCorporal { get; set; }
        public bool HidratanteFacial { get; set; }
        public bool HidratanteMaos { get; set; }
        public bool HidratantePes { get; set; }
        public bool HidratanteParaBanho { get; set; }
        public bool HidratanteOleoCorporal { get; set; }
        public bool Bronzeador { get; set; }
        public bool ProtetorSolarCorporal { get; set; }
        public bool ProtetorSolarFacial { get; set; }
        public bool ProtetorSolarLabial { get; set; }
        public bool ProdutosParaCabeloShampoo { get; set; }
        public bool ProdutosParaCabeloShampooAntiCaspa { get; set; }
        public bool ProdutosParaCabeloCondicionador { get; set; }
        public bool ProdutosParaCabeloCondicionadorAntiCaspa { get; set; }
        public bool ProdutosParaCabeloCremePentear { get; set; }
        public bool ProdutosParaCabeloMascaraTratamento { get; set; }
        public bool ProdutosParaCabeloGel { get; set; }
        public bool ProdutosParaCabeloFinalizadores { get; set; }
        public bool ProdutosPreBarbaCremeBarbear { get; set; }
        public bool ProdutosPreBarbaEspumaBarbear { get; set; }
        public bool ProdutosPreBarbaGelBarbear { get; set; }
        public bool ProdutosPreBarbaSabonete { get; set; }
        public string ProdutosPreBarbaOutros { get; set; }
        public bool ProdutosPosBarbaLocao { get; set; }
        public bool ProdutosPosbarbaBalsamo { get; set; }
        public bool ProdutosPosBarbaGel { get; set; }
        public string DetalhesCabeloMegaHairOuAplique { get; set; }
        public int DetalhesCabeloCorNatural { get; set; }
        public int DetalhesCabeloCorIntermedio { get; set; }
        public int DetalhesCabeloCorPontas { get; set; }
        public int DetalhesCabeloNuance { get; set; }
        public string DetalhesCabeloFiosBrancosPercentual { get; set; }
        public string DetalhesCabeloComprimento { get; set; }
        public string DetalhesCabeloEspessura { get; set; }
        public string DetalhesCabeloAtualCurvatura { get; set; }
        public bool CabeloTransfQuimicaNaoVirgemNatural { get; set; }
        public bool CabeloTransfColoracaoTonalizante { get; set; }
        public bool CabeloTransfPermanente { get; set; }
        public string CabeloTransfDescoloracaoReflexoLuzesMechas { get; set; }
        public bool CabeloTransfEscovaProgressiva { get; set; }
        public string CabeloTransfLuzesOuAlisamento { get; set; }  
        public int? DetalhesCabeloFrequenciaLavagemCabelo { get; set; }
        public string DetalhesCabeloCondicao { get; set; }
        public string TipoDePeleFototipo { get; set; }
        public string TipodePeleRosto { get; set; }
        public string TipoDePeleBracosPernas { get; set; }
        public string TipoDePeleMaosPe { get; set; }
        public string TipoDePeloCostasPeitoral { get; set; }
        public string TipoDePeloObservacoes { get; set; }
        public string CondicoesDasUnhasComprimento { get; set; }
        public string CondicoesDasUnhasUsoFrequenteEsmalte { get; set; }
        public string CondicoesDasUnhasCuticulasIntegrasRemovidas { get; set; }
        public string CondicoesDasUnhasEspessura { get; set; }
        public string CondicoesDasUnhasSudorese { get; set; }
        public string CondicoesDasUnhasObservacao { get; set; }
        
    }
}
