using System.Windows;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Метод для обработки нажатия кнопки "Разделить на слова"
        private void OnSplitWordsButtonClick(object sender, RoutedEventArgs e)
        {
            // Получаем текст из TextBox и разделяем на слова
            string inputText = inputTextBox.Text;
            string[] words = inputText.Split(' ');

            // Очищаем ListBox перед добавлением слов
            wordsListBox.Items.Clear();

            // Добавляем каждое слово в ListBox
            foreach (string word in words)
            {
                wordsListBox.Items.Add(word);
            }
        }

        // Метод для обработки нажатия кнопки "Переставить слова"
        private void OnReverseWordsButtonClick(object sender, RoutedEventArgs e)
        {
            // Получаем текст из TextBox и разделяем на слова
            string inputText = reverseTextBox.Text;
            string[] words = inputText.Split(' ');

            // Переставляем слова в обратном порядке
            string reversedSentence = string.Join(" ", words.Reverse());

            // Отображаем результат в Label
            reversedSentenceLabel.Content = reversedSentence;
        }
    }
}
