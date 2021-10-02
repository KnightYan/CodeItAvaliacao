using CodeItAirlines.Domain.Dtos;
using CodeItAirlines.RegraDeNegocio.Tripulante;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using static CodeItAirlines.Domain.Entidades.TripulanteEntidade;
using static CodeItAirlines.RegraDeNegocio.Tripulante.TransporteTripulantes;

namespace CodeItAirlines.RegraDeNegocio.Tripulante.Teste
{
    public class TransporteTripulantesTeste
    {
        private TripulanteDto tPiloto;
        private TripulanteDto tChefeServico;
        private TripulanteDto tOficial1;
        private TripulanteDto tOficial2;
        private TripulanteDto tComissaria1;
        private TripulanteDto tComissaria2;
        private TripulanteDto tPrisoneiro;
        private TripulanteDto tPolicial;

        public TransporteTripulantesTeste()
        {
            tPiloto = GerarTripulante();
            tPiloto.TipoTripulante = TipoTripulanteEnum.Piloto;

            tChefeServico = GerarTripulante();
            tChefeServico.TipoTripulante = TipoTripulanteEnum.ChefeServico;

            tOficial1 = GerarTripulante();
            tOficial1.TipoTripulante = TipoTripulanteEnum.Oficial;

            tOficial2 = GerarTripulante();
            tOficial2.TipoTripulante = TipoTripulanteEnum.Oficial;

            tComissaria1 = GerarTripulante();
            tComissaria1.TipoTripulante = TipoTripulanteEnum.Comissaria;

            tComissaria2 = GerarTripulante();
            tComissaria2.TipoTripulante = TipoTripulanteEnum.Comissaria;

            tPrisoneiro = GerarTripulante();
            tPrisoneiro.TipoTripulante = TipoTripulanteEnum.Presidiario;

            tPolicial = GerarTripulante();
            tPolicial.TipoTripulante = TipoTripulanteEnum.Policial;
        }

        private TripulanteDto GerarTripulante()
        {
            return new TripulanteDto
            {
                Id = Guid.NewGuid(),
                Nome = Faker.Name.First()
            };
        }

        [Test]
        public void Verificar_Limite_Tripulantes_Veiculo()
        {
            var Transporte = new TransporteTripulantes(new List<TripulanteDto>(), TipoTransporteTripulanteEnum.Veiculo);
            string ocorrencias = "";

            ocorrencias = Transporte.EmbarcarTripulante(tPiloto);
            Assert.AreEqual(ocorrencias, "");

            ocorrencias = Transporte.EmbarcarTripulante(tChefeServico);
            Assert.AreEqual(ocorrencias, "");

            ocorrencias = Transporte.EmbarcarTripulante(tComissaria1);
            Assert.IsNotEmpty(ocorrencias);
        }

        [Test]
        public void Verificar_Limite_Tripulantes_Veiculo_Embarque_Duplo()
        {
            var Transporte = new TransporteTripulantes(new List<TripulanteDto>(), TipoTransporteTripulanteEnum.Veiculo);
            string ocorrencias = "";

            ocorrencias = Transporte.EmbarcarDoisTripulante(tPiloto, tChefeServico);
            Assert.AreEqual(ocorrencias, "");

            ocorrencias = Transporte.EmbarcarDoisTripulante(tOficial1, tOficial2);
            Assert.IsNotEmpty(ocorrencias);
        }

        [Test]
        public void Verificar_Possui_Piloto_De_veiculo()
        {
            var Transporte = new TransporteTripulantes(new List<TripulanteDto>(), TipoTransporteTripulanteEnum.Veiculo);
            string ocorrencias = "";

            ocorrencias = Transporte.EmbarcarDoisTripulante(tPiloto, tOficial1);
            Assert.AreEqual(ocorrencias, "");

            Transporte.DesembargarTripulantes();
            ocorrencias = Transporte.EmbarcarDoisTripulante(tPolicial, tPrisoneiro);
            Assert.AreEqual(ocorrencias, "");

            Transporte.DesembargarTripulantes();
            ocorrencias = Transporte.EmbarcarDoisTripulante(tChefeServico, tComissaria1);
            Assert.AreEqual(ocorrencias, "");

            Transporte.DesembargarTripulantes();
            ocorrencias = Transporte.EmbarcarDoisTripulante(tComissaria1, tComissaria2);
            Assert.IsNotEmpty(ocorrencias);

            Transporte.DesembargarTripulantes();
            ocorrencias = Transporte.EmbarcarDoisTripulante(tOficial1, tOficial2);
            Assert.IsNotEmpty(ocorrencias);
        }

        [Test]
        public void Verificar_Sozinho_Com_Prisoneiro()
        {
            var Transporte = new TransporteTripulantes(new List<TripulanteDto>(), TipoTransporteTripulanteEnum.Veiculo);
            string ocorrencias = "";

            ocorrencias = Transporte.EmbarcarDoisTripulante(tPrisoneiro, tPolicial);
            Assert.AreEqual(ocorrencias, "");

            Transporte.DesembargarTripulantes();
            ocorrencias = Transporte.EmbarcarDoisTripulante(tPrisoneiro, tOficial2);
            Assert.IsNotEmpty(ocorrencias);

            Transporte.DesembargarTripulantes();
            ocorrencias = Transporte.EmbarcarDoisTripulante(tPrisoneiro, tPiloto);
            Assert.IsNotEmpty(ocorrencias);

            Transporte.DesembargarTripulantes();
            ocorrencias = Transporte.EmbarcarDoisTripulante(tPrisoneiro, tComissaria2);
            Assert.IsNotEmpty(ocorrencias);

            Transporte.DesembargarTripulantes();
            ocorrencias = Transporte.EmbarcarDoisTripulante(tPrisoneiro, tChefeServico);
            Assert.IsNotEmpty(ocorrencias);
        }

        [Test]
        public void Verificar_Piloto_Sozinho_Com_Comissaria()
        {
            var Transporte = new TransporteTripulantes(new List<TripulanteDto>(), TipoTransporteTripulanteEnum.Aviao);
            string ocorrencias = "";

            ocorrencias = Transporte.EmbarcarDoisTripulante(tPiloto, tComissaria1);
            Assert.IsNotEmpty(ocorrencias);

            Transporte.DesembargarTripulantes();
            Transporte.EmbarcarDoisTripulante(tPiloto, tChefeServico);
            ocorrencias = Transporte.EmbarcarTripulante(tComissaria1);
            Assert.AreEqual(ocorrencias, "");
        }

        [Test]
        public void Verificar_ChefeServico_Sozinho_Com_Oficial()
        {
            var Transporte = new TransporteTripulantes(new List<TripulanteDto>(), TipoTransporteTripulanteEnum.Aviao);
            string ocorrencias = "";

            ocorrencias = Transporte.EmbarcarDoisTripulante(tChefeServico, tOficial1);
            Assert.IsNotEmpty(ocorrencias);

            Transporte.DesembargarTripulantes();
            Transporte.EmbarcarDoisTripulante(tPiloto, tChefeServico);
            ocorrencias = Transporte.EmbarcarTripulante(tOficial1);
            Assert.AreEqual(ocorrencias, "");
        }
    }
}