using CurrieTechnologies.Razor.SweetAlert2;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using WebConta.Frontend.Repositories;
using WebConta.Shared.Entities;

namespace WebConta.Frontend.Pages.Tipos
{
    public partial class TipoEdit
    {
        private Tipo? tipo;

        private TipoForm? tipoForm;

        [Inject] private IRepository Repository { get; set; } = null!;

        [Inject] private NavigationManager NavigationManager { get; set; } = null!;

        [Inject] private SweetAlertService SweetAlertService { get; set; } = null!;

        [EditorRequired, Parameter] public int Id { get; set; }

        protected override async Task OnParametersSetAsync()
        {
            var respomnseHttp = await Repository.GetAsync<Tipo>($"/api/tipos/{Id}");

            if (respomnseHttp.Error)
            {
                if (respomnseHttp.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    NavigationManager.NavigateTo("tipos");
                }
                else
                {
                    var message = await respomnseHttp.GetErrorMessageAsync();

                    await SweetAlertService.FireAsync("Error", message, SweetAlertIcon.Error);
                }
            }
            else
            {
                tipo = respomnseHttp.Response;
            }
        }

        private async Task EditAsync()
        {
            var responseHttp = await Repository.PutAsync("/api/tipos", tipo);

            if (responseHttp.Error)
            {
                var message = await responseHttp.GetErrorMessageAsync();

                await SweetAlertService.FireAsync("Error", message, SweetAlertIcon.Error);
                return;
            }

            Return();

            var toast = SweetAlertService.Mixin(new SweetAlertOptions
            {
                Toast = true,
                Position = SweetAlertPosition.BottomEnd,
                ShowConfirmButton = true,
                Timer = 3000
            });
            await toast.FireAsync(icon: SweetAlertIcon.Success, message: "Registro editado con exito");
        }

        private void Return()
        {
            tipoForm!.FormPostedSuccessfully = true;
            NavigationManager.NavigateTo("tipos");
        }
    }
}