using System;
using System.Linq;
using Microsoft.Practices.Unity;
using TiendaArreglos.Client.Infrastructure.Implementation.Reporting;
using TiendaArreglos.Client.Infrastructure.Implementation.Serialization;
using TiendaArreglos.Client.Infrastructure.Interface.Reporting;
using TiendaArreglos.Client.Infrastructure.Interface.Serialization;
using TiendaArreglos.Client.Model;

namespace TiendaArreglos.Client.DiContainer
{
    public static class Container
    {
        public static IUnityContainer UnityContainer = new UnityContainer()
        .RegisterType<ISerializer<TiendaArreglosConfig>, SerializerBase<TiendaArreglosConfig>>()
        .RegisterType<IReportingService, ReportingService>();
    }
}