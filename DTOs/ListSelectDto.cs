namespace DemoWeb.DTOs
{
    #region 類似MVC的ViewModel 降低複雜度用
    public class ListSelectDto
    {
        public int Id { get; set; }
        public string? Estatename { get; set; }
        public string? City { get; set; }
        public string? Type { get; set; }
        public int? Numberofrooms { get; set; }
        public int? Price { get; set; }

    }
    #endregion
}
