using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace TestAr.IoC
{
    public static class FactoryContainer
    {
        private static UnityContainer _unityContainer;

        public static void RegisterContainer(UnityContainer unityContainer)
        {
            if (unityContainer == null)
            {
                throw new Exception("Container null");
            }

            _unityContainer = unityContainer;
        }

        public static TServicio Resolver<TServicio>()
        {
            return _unityContainer.Resolve<TServicio>();
        }

    }
}
