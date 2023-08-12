import re

class File:
    '''Взаимодействие с файлами'''

    file_input = 'in.txt'
    file_output = 'out.txt'

    def read(self):
        with open(self.file_input, 'r') as f:
            return f.read()

    def write(self, answer):
        with open(self.file_output, 'w') as f:
            for key in answer:
                f.write(f'{key}: {answer[key]} \n')


def only_words(text):
    text = re.sub(r'[^\w\s]','',text)
    return text


def search_iteger_numbers(text):
    text = text.replace('–', '')
    text = text.replace('-', '')
    text = text.replace('(', '')
    text = text.replace(')', '')
    counter = 0
    for word in text:
        try:
            int(word)
            counter += 1
        except: pass
    return counter


def A_couner_search(words):
    c = 0
    for word in words:
        if word[0] == 'А' or word[0] == 'A':
            c += 1

    return c


def i_counter_search(words):
    c = 0
    for word in words:
        if word[-1] == 'и':
            c += 1
    return c


def lo_counter_func(words):
    c = 0
    for word in words:
        if 'ло' in word:
            c += 1
    return c


def staples_counter_func(text):
    c = 0
    for character in text:
        if character == '(' or character == ')':
            c += 1

    return c


def text_with_out_staples_func(text):
    answer = ''
    flag = False
    for character in text:
        if character == '(':
            flag = True
        elif character == ')':
            flag = False
        elif not flag:
            answer += character

    return answer


def max_replace_counter_func(text):
    max_len = 0
    now_len = 1
    start_char = text[0]
    for character in text[1:]:
        if character == start_char:
            now_len += 1
        elif now_len > max_len:
            max_len = now_len
            now_len = 1
        start_char = character

    return max_len


def characters_request_func(text):
    numbers = 0
    characters = 0
    alphabet = 'qazwsxedcrfvtgbyhnujmikolp'
    ALPHABET = 'QWERTYUIOPASDFGHJKLZXCVBNM'
    for character in text:
        try:
            int(character)
            numbers += 1
        except:
            if character in alphabet or character in ALPHABET:
                characters += 1
    if numbers > characters:
        return 'Больше цифр'
    else:
        return "Больше латинских букв"