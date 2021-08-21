using System.Collections.Generic;
using МоитеГуми.Models.Обява;

namespace МоитеГуми.Services.Obqwi
{
    public interface IObqwiServices
    {
        ObqwaQueryServicesModel All(
            string marka,
            string searchTerm,
            ObqwiSorting obqwiSorting,
            int currentPage,
            int obqwiPerPage);

        ObqwaDetailsServiceModel Details(int obqwaId);
        //ObqwaDetailsServiceModel Edit(string marka, string description, int year, int categoryId, string imageUrl, string size, int dealerId);

        int Create(
                string marka,
                string description,
                int year,
                int categoryId,
                string imageUrl,
                string size,
                int dealerId);
        bool Edit(
                int obqwaId,
                string marka,
                string description,
                int year,
                int categoryId,
                string imageUrl,
                string size);

        IEnumerable<ObqwaServicesModel> ByUser(string userId);

        bool IsByDealer(int obqwaId, int dealerId);

        IEnumerable<string> AllMarki();

        IEnumerable<ObqwaCategoryServiceModel> AllCategories();

        bool CategoryExist(int categoryId);



    }
}
