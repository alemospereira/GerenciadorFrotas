using AplicacaoFrotas.Aplicacoes;
using DadosFrotas.Repositorio;
using DominioFrotas.Interfaces;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace DependenciaFrota
{
    public static class UnityConfig
    {
        public static void Start()
        {
            var container = Container();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
        private static IUnityContainer Container()
        {
            var container = new UnityContainer();

            container.RegisterType<IVeiculoAplicacao, VeiculoAplicacao>();
            container.RegisterType<IVeiculoRepositorio, VeiculoRepositorio>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            return container;
        }
    }
}