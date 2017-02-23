using LinXamarinTest.Model;
using LinXamarinTest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LinXamarinTest.Data
{
    public interface IRestService
    {
        Task<List<CountryModel>> RefreshDataAsync();

        Task SaveTodoItemAsync(TodoItem item, bool isNewItem);

        Task DeleteTodoItemAsync(string id);

    }
}
