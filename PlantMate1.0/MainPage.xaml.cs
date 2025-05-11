namespace PlantMate1._0;

using Microsoft.Maui.Controls;
public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent(); //initializes all the UI elements defined in XAML file
        LoadPlantData(); //Method for Loading data
        
        // Make a timer for updating the data every * minutes
        // Persist the data on the ESP32, Send back with WIFI
    }

   
    private async void OnRefreshClicked(object sender, EventArgs e)  // This method is triggered when the "Refresh" button is clicked
    {
        await LoadPlantData(); // Calls LoadPlantData method again to refresh the displayed data
    }

    private async Task LoadPlantData() // Later: Replace with actual ESP data, Just using as Testing Data atm
    {
        // Later: add ESP data
        var moisture = 48;
        
        // Later: Mention about Hours and Minutes as well 
        var lastWatered = DateTime.Now.AddDays(-2);

        // Create a string that shows the current moisture level as a percentage
        string moistureText = "Moisture: " + moisture + "%"; 
        
        // Assign it to the MoistureLabel (XAML) to display it on the screen
        MoistureLabel.Text = moistureText; 
        
        
        // Update the UI to show how many days it's been since the plant was last watered.
        // Then calculates the difference in days between the current and the last watered date.
        DaysLabel.Text = $"Days since last watering: {(DateTime.Now - lastWatered).Days}"; 

        // Later: Will need a lot of FineTuning and testing depending on the plant probably
        if (moisture > 40)
            PlantFace.Source = "happy.png"; 
        else
            PlantFace.Source = "sad.png";
    }
    
    // Later: Add Logic For Checking PH levels of the soil
}
