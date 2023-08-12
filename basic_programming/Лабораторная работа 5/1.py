'''
Задание 1. Создайте текстовый файл in.txt, в который поместите текст (объёмом примерно 0,5 страницы).
Затем ваша программа должна считать данные из файла, выполнить операции в соответствии с вариантом.
Результат нужно записать в текстовый файл out.txt.
'''
from funcs_1 import *

file = File()
search_word = input('Введите слово которые нужно искать: ')
replace_word = input('Введите слово на которые нужно заменить: ')
text = file.read()
text_words = only_words(text)

words = [str(word) for word in text_words.split()]

search_word_counter = text_words.count('search_word') # 1. Подсчитать сколько раз в тексте встречается заданное слово
text_with_replace_word = text.replace(search_word, replace_word) # 2. Заменить по всему тексту заданное слово на другое
integer_numbers_counter = search_iteger_numbers(text) # 3. Подсчет целых числе в тексте
with_out_whitespace = re.sub(r'\s+', ' ', text) # 4. Удалить из текста лишние пробелы
with_out_search_word = text.replace(search_word, '') # 5. Удалить все вхождения заданного слова из текста
A_counter = A_couner_search(words) # 6. колво слов начинающиеся с А
i_counter = i_counter_search(words) # 7. колво слов заканчивающиеся с и
lo_counter = lo_counter_func(words) # 8. колво слов содержащих ло
staples_counter = staples_counter_func(text) # 9. колво откр и закр фиг скоб
text_with_out_staples = text_with_out_staples_func(text) # 10. текст без содержания внутреннего скобок
max_replace_counter = max_replace_counter_func(text) # 11. максимальное колво идущих подряд символов
characters_request = characters_request_func(text) # 12. кого больше цифр или букв

answer = {
    '1': search_word_counter,
    '2': text_with_replace_word,
    '3': integer_numbers_counter,
    '4': with_out_whitespace,
    '5': with_out_search_word,
    '6': A_counter,
    '7': i_counter,
    '8': lo_counter,
    '9': staples_counter,
    '10': text_with_out_staples,
    '11': max_replace_counter,
    '12': characters_request
}
file.write(answer)