using System.Collections.ObjectModel;
using Act_2_Real.Models;

namespace Act_2_Real.Pages;

public partial class ProgramacionPage : ContentPage
{
    public ObservableCollection<DatosCuriososModels> CuriositiesList { get; set; }

    public ProgramacionPage()
    {
        InitializeComponent();

        // Cargar datos curiosos
        CuriositiesList = new ObservableCollection<DatosCuriososModels>
            {
                new DatosCuriososModels
                {
                    Title = "El virus Stuxnet",
                    Description = "Stuxnet fue un virus inform�tico desarrollado para sabotear instalaciones nucleares. Es un claro ejemplo de c�mo la programaci�n puede ser usada como arma."
                },
                new DatosCuriososModels
                {
                    Title = "El incidente del Therac-25",
                    Description = "Errores en el software del Therac-25 provocaron radiaciones masivas, causando varias muertes. Un recordatorio de c�mo los errores en software pueden tener consecuencias mortales."
                },
                // Agregar m�s curiosidades aqu�
            };

        BindingContext = this;
    }
}