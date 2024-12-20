import sys
from os import system
import platform
#auto-py-to-exe


def clean():
    """
    Clears the console
    """
    os_name = platform.system().lower()
    if 'windows' in os_name:
        system('cls')
    else:
        system('clear')


def show(game):
    print(' 1 | 2 | 3 ', sep='', end='')
    print('\n---+---+---')
    print(' 4 | 5 | 6 ', sep='', end='')
    print('\n---+---+---')
    print(' 7 | 8 | 9 ', sep='', end='')
    print('\n===========')
    x = ''
    y = ''
    for i in range(len(game)):
        if i % 2 == 0:
            x += game[i]
        else:
            y += game[i]
    for i in range(1,10):
        if str(i) in x:
            print(' X ', sep='', end='')
        elif str(i) in y:
            print(' O ', sep='', end='')
        else:
            print('   ', sep='', end='')
        if i == 3 or i == 6:
            print('\n---+---+---')
        elif i != 9:
            print('|', sep='', end='')


def what():
    x = input('want to play again?(yes/no)')
    if x == 'yes':
        clean()
        main('')
    else:
        print('see you! :)')
        x = input('press any key!')
    sys.exit(0)


def check(game):
    if len(game) >= 5:
        win = ['123','456','789','147','258','369','159','357']
        x = ''
        y = ''
        for i in range(len(game)):
            if i % 2 == 0:
                x += game[i]
            else:
                y += game[i]
        for i in win:
            if i[0] in x and i[1] in x and i[2] in x:
                return -1
            if i[0] in y and i[1] in y and i[2] in y:
                return 1
    return 0


def status(game, who):
    if who == -1:
        print('You won...')
        what()
    if who == 1:
        print('I won...')
        what()
    if who == 0 and len(game) == 9:
        print('Draw...')
        what()


def minmax(game, maximizing):
    status = check(game)
    if status == -1 or status == 1 or (len(game) == 9 and status == 0):
        return status
    
    best_score = 0
    possible_numbers = ['1', '2', '3', '4', '5', '6', '7', '8', '9'] 
    if maximizing:
        for i in range(len(possible_numbers)):
            if possible_numbers[i] not in game:
                score = minmax(game + possible_numbers[i], False)
                if i == 0:
                    best_score = score
                else:
                 best_score = max(best_score, score)
    else:
        for i in range(len(possible_numbers)):
            if possible_numbers[i] not in game:
                score = minmax(game + possible_numbers[i], True)
                if i == 0:
                    best_score = score
                else:
                    best_score = min(best_score, score)
    return best_score


def bot_move(game):
    possible_moves = []
    for i in ['1', '2', '3', '4', '5', '6', '7', '8', '9']:
        if i not in game:
            possible_moves.append(i)
    best_score = 0
    best_move = ''
    for i in possible_moves:
        score = minmax(game + i, False)
        if i == possible_moves[0]:
            best_move = i
            best_score = score 
        elif best_score <= score:
            best_move = i
            best_score = score
        print(f' {i}, score = {score}, best_score = {best_score}, best_move = {best_move}')
    return best_move


def player_move(game):
    while True:
        x = input('\nYour move: ')
        if x not in game and (x == '1' or x == '2' or x == '3' or x == '4' or x == '5' or x == '6' or x == '7' or x == '8' or x == '9'):
            break
        else:
            print('Try again.')
    return x


def main(game):
    while True:
        show(game)
        player = player_move(game)
        game += player
        status(game, check(game))
        bot = bot_move(game)
        game += bot
        #print(f'My move: {bot}')
        status(game, check(game))
        #clean()


main('')
