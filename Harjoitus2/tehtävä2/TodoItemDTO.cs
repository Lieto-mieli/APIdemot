public class TodoItemDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int Reward { get; set; }
    public TodoItemDTO() { }
    public TodoItemDTO(Quest todoItem) =>
    (Id, Name, Description, Reward) = (todoItem.Id, todoItem.Name, todoItem.Description, todoItem.Reward);
}