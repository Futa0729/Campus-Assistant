using CampusAssistant.Models;

namespace CampusAssistant.DataLayer
{
    public static class TermStore
    {
        private static List<Term> terms = new ()
        {
            new Term
            {
                English = "credit",
                Japanese = "単位",
                EnglishDefinition = "a unit that measures a course's academic work and tracks progress toward a degree.",
                JapaneseDefinition = "科目ごとの学習の基準量"
            },
            new Term
            {
                English = "syllabus",
                Japanese = "シラバス",
                EnglishDefinition = "a document that outlines the expectations, policies, and schedule for a course, acting as a roadmap for students and a contract between students and faculty",
                JapaneseDefinition = "大学の授業科目ごとに、その内容、目的、年間スケジュール、評価方法などを詳しくまとめた「授業計画書」"
            },
            // Add more terms as needed
        };

        public static List<Term> GetTerms()
        {
            return terms;
        }
    }
}