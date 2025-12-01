using CampusAssistant.Models;

namespace CampusAssistant.DataLayer
{
    public static class GuideStore
    {
        public static List<Guide> guides = new()
        {
            new Guide
            {
                TitleEn = "How to Register for Classes",
                TitleJp = "クラスの登録方法",
                StepsEn =
                {
                    "1. Log in to the student portal.",
                    "2. Navigate to the 'Course Registration' section.",
                    "3. Select desired courses and add them to your schedule.",
                    "4. Confirm your registration."
                },
                StepsJp =
                {
                    "1. 学生ポータルにログインします。",
                    "2. 「コース登録」セクションに移動します。",
                    "3. 希望するコースを選択してスケジュールに追加します。",
                    "4. 登録を確認します。"
                }
            },
        };
        public static List<Guide> GetGuides()
        {
            return guides;
        }
    }
}