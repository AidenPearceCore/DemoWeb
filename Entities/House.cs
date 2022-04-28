namespace DemoWeb.Entities
{

    #region House的Model
    public partial class House
    {
        /// <summary>
        /// 物件編號
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// 物件名稱
        /// </summary>
        public string? Estatename { get; set; }
        
        /// <summary>
        /// 座落市區
        /// </summary>
        public string? City { get; set; }
        
        /// <summary>
        /// 房屋型態
        /// </summary>
        public string? Type { get; set; }
        
        /// <summary>
        /// 物件樓層
        /// </summary>
        public string? Floor { get; set; }
        
        /// <summary>
        /// 物件房數
        /// </summary>
        public int? Numberofrooms { get; set; }
        
        /// <summary>
        /// 物件總價
        /// </summary>
        public int? Price { get; set; }
    }
    #endregion
}
