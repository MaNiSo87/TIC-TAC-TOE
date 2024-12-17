import sys

def show(game):
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


def end(game, who):
    if who == 'X':
        print('You won...')
        sys.exit(0)
    elif who == 'O':
        print('I won...')
        sys.exit(0)
    elif len(game) == 9:
        print('Draw...')
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
        sys.exit(0)
    if who == 1:
        print('I won...')
        sys.exit(0)
    if who == 0 and len(game) == 9:
        print('Draw...')
        sys.exit(0)


def minmax(game, maximizing):
    status = check(game)
    if status == -1 or status == 1 or (len(game) == 9 and status == 0):
        return status
    
    if maximizing:
        best_score = 0
        for i in ['1', '2', '3', '4', '5', '6', '7', '8', '9']:
            if i not in game:
                score = minmax(game + i, False)
                best_score = max(best_score, score)
        return best_score
    else:
        best_score = 0
        for i in ['1', '2', '3', '4', '5', '6', '7', '8', '9']:
            if i not in game:
                score = minmax(game + i, True)
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
        elif best_score < score:
            best_move = i
            best_score = score
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
        player = player_move(game)
        game += player
        status(game, check(game))
        bot = bot_move(game)
        game += bot
        print(f'My move: {bot}')
        status(game, check(game))
        show(game)






main('')