namespace MitsAdvisor.Web.Data;

using MitsAdvisor.Web.Models;

public static class DbInitializer
{
  public static async Task Initialize(MitsadvisorContext dbContext)
  {
    if (dbContext.Restaurants.Any()
        && dbContext.Menus.Any()
        && dbContext.MenuItems.Any())
    {
      return;
    }

    var patatofloudes = new MenuItem() { Name = "Πατατόφλουδες" };
    var ntakos = new MenuItem()
    {
      Name = "Ντάκος με τυροκοπανιστή & πιπεριές",
      Description =
        " Με ντομάτα τριμμένη, τυροκοπανιστή, πιπεριά πράσινη ψιλοκομμένη, κρεμμύδι και extra παρθένο ελαιόλαδο.",
    };
    var salataBalsamika = new MenuItem()
    {
      Name = "Balsamika",
      Description = "Σαλάτα με ρόκα, σπανάκι, μαρούλι, λόλα & κοτόπουλο καραμελωμένο με βαλσάμικο",
    };
    var fetaTragoudisth = new MenuItem() { Name = "Φέτα τραγουδιστή" };
    var tiganiaKotopoulo = new MenuItem() { Name = "Τηγανιά Κοτόπουλο" };

    var elaikonMenu = new Menu()
    {
      MenuItems = new[] { patatofloudes, ntakos, salataBalsamika, fetaTragoudisth, tiganiaKotopoulo, },
    };

    var elaikonRestaurant = new Restaurant() { Name = "Ελαϊκόν", Menus = new[] { elaikonMenu } };

    var politikiSalata = new MenuItem()
    {
      Name = "Πολίτικη ψιλοκομμένη",
      Description = "Σαλάτα με ντομάτα, αγγούρι, μαϊντανό, πιπεριά, κρεμμύδι, χυμό ρόδι, λεμόνι & ελαιόλαδο",
    };
    var giaourtlouKebap = new MenuItem()
    {
      Name = "Γιαουρτλού Κεμπάπ μερίδα",
      Description =
        "Με γιαούρτι & σάλτσα από φρέσκια ντομάτα. Συνοδεύεται από αλάδωτη πίτα, ψητή ντομάτα, πιπεριά, ψιλοκομμένο κρεμμύδι, φρέσκο μαϊντανό & χοντρό αλάτι",
    };
    var kaserliKebap = new MenuItem()
    {
      Name = "Κασερλί κεμπάπ μερίδα",
      Description =
        "Με λιωμένο κασέρι. Συνοδεύεται από αλάδωτη πίτα, ψητή ντομάτα, πιπεριά, ψιλοκομμένο κρεμμύδι, φρέσκο μαϊντανό & χοντρό αλάτι",
    };

    var kyrAristosMenu = new Menu() { MenuItems = new[] { politikiSalata, giaourtlouKebap, kaserliKebap } };

    var kyrAristosRestaurant = new Restaurant() { Name = "Κυρ Αρίστος", Menus = new[] { kyrAristosMenu } };

    var restaurants = new List<Restaurant>() { elaikonRestaurant, kyrAristosRestaurant };

    dbContext.Restaurants.AddRange(restaurants);
    await dbContext.SaveChangesAsync();
  }
}
