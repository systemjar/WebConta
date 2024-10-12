using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.Metrics;
using WebConta.Frontend.Repositories;
using WebConta.Shared.Entities;

namespace WebConta.Frontend.Pages.Tipos
{
    public partial class TipoCreate
    {
        //Vamos a referenciar el formulario CountryForm, es la representacion del codigo blazor en mi componente c#
        private TipoForm? tipoForm;

        //Inyectamos el repositorio para poder utilizar el post y el put
        [Inject] private IRepository Repository { get; set; } = null!;

        //Inyectamos el NavigationMannager par navegar entre paginas de la solucion
        [Inject] private NavigationManager NavigationManager { get; set; } = null!;

        //Inyectamos el SweetAlert2
        [Inject] private SweetAlertService SweetAlertService { get; set; } = null!;

        //Creamos un atributo privado Country que es Pais que vamos a Crear
        private Tipo tipo = new();

        //Cuando se crea el pais se pone en blanco y cuando se manda al formulario se llenan los cambios para luego darle Post

        //Metodo para crear el pais
        private async Task CreateAsync()
        {
            //Mandamos al Post la url y el objeto
            var responseHttp = await Repository.PostAsync("api/tipos", tipo);
            if (responseHttp.Error)
            {
                //Recolectamos el error
                var message = await responseHttp.GetErrorMessageAsync();
                await SweetAlertService.FireAsync("Error", message);
                return;
            }

            //Si guardo el objeto
            Return();

            //Hacemos un toast (mensage) indicando que se grabo el registro satisfactoriamente
            var toast = SweetAlertService.Mixin(new SweetAlertOptions
            {
                Toast = true,
                Position = SweetAlertPosition.BottomEnd,
                ShowConfirmButton = true,
                Timer = 3000
            });
            await toast.FireAsync(icon: SweetAlertIcon.Success, message: "Registro agregado con exito");
        }

        private void Return()
        {
            //Prendemos que si se posteo correctamente
            tipoForm!.FormPostedSuccessfully = true;
            NavigationManager.NavigateTo("/tipos");
        }
    }
}