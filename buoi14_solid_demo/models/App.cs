public class App<T> where T : class
{
    public List<T> lstItem { get; set; } = new List<T>();

    public void AddNewItem(T newItem)
    {
        this.lstItem.Add(newItem);
    }

    public void RemoveItem(int idDelete)
    {
        T? itemToDelete = this.lstItem.Find((item) =>
        {
            if (item is null)
            {
                return false;
            }

            dynamic dynamicItem = item;
            return dynamicItem.Id == idDelete;
        });

        if (itemToDelete != null)
        {
            this.lstItem.Remove(itemToDelete);
        }
    }
}