using Microsoft.AspNetCore.Components;
using WebConta.Frontend.Repositories;
using WebConta.Shared.Entities;

namespace WebConta.Frontend.Pages.Tipos
{
    public partial class TiposIndex
    {
        /*Inyectamos el Repositorio pero el objeto tiene que ir en con la primera en Mayuscula tipo propiedad con {get; y set;} lo injectamos en la clase _Imports.razor */
        [Inject] private IRepository Repository { get; set; } = null!;

        //Creamos una lista tipo countries con ? porque puede ser null
        public List<Tipo>? LTipos { get; set; }

        //Sobre cargamos el metodo qe se ejecuta cuando carga la pagina
        protected async override Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            //Obtenemos una lista de paises utilizando el componente repository generico que creamos
            //Utilizamos el GetAsync al que se le manda la url "api/tipos" y el devuelve el responseHttp con todo el contenido de respuesta, en este caso una lista

            var responsehttp = await Repository.GetAsync<List<Tipo>>("api/tipos");
            LTipos = responsehttp.Response;
        }
    }
}
