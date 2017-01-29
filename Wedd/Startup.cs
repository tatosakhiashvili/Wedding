using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wedd.Startup))]
namespace Wedd {
	public partial class Startup {
		public void Configuration(IAppBuilder app) {

		}
	}
}
