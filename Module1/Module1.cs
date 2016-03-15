using Microsoft.Practices.Unity;
using Module1.Views;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{
    public class Module1 : IModule
    {
        private readonly IUnityContainer _container;
        private readonly IRegionManager _manager;

        public Module1(IUnityContainer container, IRegionManager manager)
        {
            _container = container;
            _manager = manager;
        }

        public void Initialize()
        {
            

            var view = _container.Resolve<Module1View>();
            _manager.Regions["MainRegion"].Add(view);


        }
    }
}
