using CampusAssistant.Models;

namespace CampusAssistant.DataLayer
{
    public static class CampusStore
    {
        private static List<CampusBuildings> buildings = new ()
        {
            new CampusBuildings
            {
                NameEn = "Library",
                NameJp = "図書館",
                DescriptionEn = "A place where students can study, borrow books, and access academic resources.",
                DescriptionJp = "学生が勉強したり、本を借りたり、学術資料にアクセスしたりできる場所。"
            },
            new CampusBuildings
            {
                NameEn = "Greenwood Student Center (GSC)",
                NameJp = "グリーンウッド学生センター (GSC)",
                DescriptionEn = "A hub for student activities, services, and socializing.",
                DescriptionJp = "学生の活動、サービス、交流の中心地。"
            },
            // Add more terms as needed
        };

        public static List<CampusBuildings> GetBuildings()
        {
            return buildings;
        }
    }
}