namespace TodoApi.Dtos
{
    public class PostTodoItemDto
    {
        public string Title { get; set; } = string.Empty;
        public bool Done { get; set; }
    }
}
