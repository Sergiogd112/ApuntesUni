from math import *
from random import *
from kandinsky import *
from ion import *
from time import *
from kandinsky import fill_rect as F
from random import randint as R
from ion import keydown as K

# screen width and height
SCRW = 322
SCRH = 222
SCRA = SCRW * SCRH


brown = (101, 67, 33)


world = 1
game = True
bg = (95, 123, 233)

# player
psc = 0
pe = 9
plife = 3

mario_scale = 2

def func():
    rmn=nw/em
    vrmn=(2*nw/rhosclopt)**.5   
def pause():
    draw_string(
        "(PAUSED)", 110, 100, (randint(0, 255), randint(0, 255), randint(0, 255)), bg
    )
    while K(KEY_OK):
        pass
    while not K(KEY_OK):
        pass
    while K(KEY_OK):
        draw_string("        ", 110, 100, bg, bg)
        pass


booljump, compteur_saut, L_saut = (
    False,
    0,
    [int(-0.4 * (x / 4) ** 2 + 70) for x in range(-52, 52)] + [0],
)
# player size
side = 18
# ground
y_floor = 200

x = 12
# player on floor
y = y_floor - side

# just a counter for the rgb effect on the cube
c = 0

score = 0
# variable for the square: length of each part
c_1 = side // 7
c_2 = side // 12
c_3 = side - c_1 * 2 - c_2 * 2

# player colors
c_col_1 = (randint(0, 255), randint(0, 255), randint(0, 255))
c_col_3 = (255, 255, 255)


def display_square():
    c_1 = side // 7
    c_2 = side // 8
    c_3 = side - c_1 * 2 - c_2 * 2

    # mario head
    F(x + 3 * 2, y - 7 * 2, 5 * 2, 1 * 2, "red")
    F(x + 2 * 2, y - 6 * 2, 9 * 2, 1 * 2, "red")
    F(x + 2 * 2, y - 5 * 2, 3 * 2, 1 * 2, brown)
    F(x + 5 * 2, y - 5 * 2, 2 * 2, 1 * 2, "orange")
    F(x + 7 * 2, y - 5 * 2, 1 * 2, 1 * 2, "black")
    F(x + 8 * 2, y - 5 * 2, 1 * 2, 1 * 2, "orange")
    F(x + 1 * 2, y - 4 * 2, 1 * 2, 1 * 2, brown)
    F(x + 2 * 2, y - 4 * 2, 1 * 2, 1 * 2, "orange")
    F(x + 3 * 2, y - 4 * 2, 1 * 2, 1 * 2, brown)
    F(x + 4 * 2, y - 4 * 2, 3 * 2, 1 * 2, "orange")
    F(x + 7 * 2, y - 4 * 2, 1 * 2, 1 * 2, "black")
    F(x + 8 * 2, y - 4 * 2, 3 * 2, 1 * 2, "orange")
    F(x + 1 * 2, y - 3 * 2, 1 * 2, 1 * 2, brown)
    F(x + 2 * 2, y - 3 * 2, 1 * 2, 1 * 2, "orange")
    F(x + 3 * 2, y - 3 * 2, 2 * 2, 1 * 2, brown)
    F(x + 5 * 2, y - 3 * 2, 3 * 2, 1 * 2, "orange")
    F(x + 8 * 2, y - 3 * 2, 1 * 2, 1 * 2, "black")
    F(x + 9 * 2, y - 3 * 2, 3 * 2, 1 * 2, "orange")
    F(x + 2 * 2, y - 2 * 2, 1 * 2, 1 * 2, brown)
    F(x + 3 * 2, y - 2 * 2, 4 * 2, 1 * 2, "orange")
    F(x + 7 * 2, y - 2 * 2, 4 * 2, 1 * 2, "black")
    F(x + 3 * 2, y - 1 * 2, 6 * 2, 1 * 2, "orange")

    F(x, y, side, c_1, c_col_1)
    F(x, y + side - c_1, side, c_1, c_col_1)
    F(x, y + c_1, c_1, c_3 + c_2 * 2, c_col_1)
    F(x + side - c_1, y + c_1, c_1, c_3 + c_2 * 2, c_col_1)

    F(x + c_1, y + c_1, side - 2 * c_1, c_2, c_carre)
    F(x + c_1, y + c_1 + c_2 + c_3, side - 2 * c_1, c_2, c_carre)
    F(x + c_1, y + c_1 + c_2, c_2, c_3, c_carre)
    F(x + c_1 + c_2 + c_3, y + c_1 + c_2, c_2, c_3, c_carre)

    F(
        x + c_1 + c_2,
        y + c_1 + c_2,
        side - (c_1 + c_2) * 2,
        side - (c_1 + c_2) * 2,
        c_col_3,
    )


# bullets
L_projectiles = []
w_projectile = 8
h_projectile = 6
# velocity of bullets
v_projectile = 4
# ground
y_ground1 = y_floor + (222 - y_floor) // 3
# grass on dirt
y_ground2 = 215
# 3 different colors for 3 different things
c_herbe = (25, 111, 61)
c_ground1 = (160, 64, 0)
c_ground2 = (96, 48, 0)


def display_ground():
    F(0, y_floor, 320, 222 - y_floor, c_herbe)
    F(0, y_ground1, 320, 222 - y_ground1, c_ground1)
    for i in range(80):  # 320
        random = randint(0, 20)
        h = random * (y_ground2 - y_ground1) // 20
        F(i * 4, y_ground1, 4, h, c_herbe)
    for i in range(190):  # 190
        xground, yground = randint(0, 320), randint(y_ground2 - 4, 222)
        F(xground, yground, 3, 3, c_ground2)
    L_col = [(88, 140, 0), (0, 88, 24), (0, 168, 0)]

    for i in range(320):  # 320
        cground, xground, yground = (
            L_col[randint(0, 2)],
            randint(0, 320),
            randint(y_floor, y_ground1),
        )
        F(xground, yground, 2, 2, cground)


F(0, 0, 322, 222, bg)
display_ground()
# ??
c_carre = (148, 49, 38)
F(x, y, side, side, c_carre)
Direction = 1
bool_shoot = True

while True:

    draw_string("World:" + str(world), 250, 0, "black", bg)
    draw_string("Life:" + str(plife), 6, 0, "blue", bg)
    # ??
    precedent_y = y

    if keydown(KEY_LEFT):
        Direction = -1
        if x > 0:
            fill_rect(x + side - 2, y, 2, side, bg)
            # erase head
            fill_rect(x + 8 * 2, y - 7 * 2, 5 * 2, 7 * 2, bg)
            x -= 2

    elif keydown(KEY_RIGHT):
        Direction = 1
        if x + side <= 320:
            fill_rect(x, y, 2, side, bg)
            # erase head
            fill_rect(x, y - 7 * 2, 4 * 2, 7 * 2, bg)
            x += 2

    if keydown(KEY_BACKSPACE):
        if y == y_floor - side:
            booljump = True
    # player shoots
    if keydown(KEY_TOOLBOX):
        if bool_shoot:
            bool_shoot = False

            if len(L_projectiles) < 15:
                if Direction == 1:
                    L_projectiles.append([x + side + 3, y + 4, 1, side // 3, side // 4])
                else:
                    L_projectiles.append(
                        [x - 3 - w_projectile, y + 4, -1, side // 3, side // 4]
                    )
    elif not (keydown(KEY_TOOLBOX)):
        bool_shoot = True

    # bullets fired (L_projectiles)
    if len(L_projectiles) != 0:
        for i in L_projectiles:
            # bullets reach left or right
            if i[0] > 320 or i[0] < 0 - i[3]:
                L_projectiles.remove(i)
            else:
                if i[2] == 1:
                    x_eff_projectile = i[0]
                else:
                    x_eff_projectile = i[0] + i[3] - v_projectile

                F(x_eff_projectile, i[1], v_projectile, i[4], bg)
                i[0] += v_projectile * i[2]
                F(i[0], i[1], i[3], i[4], (0, 0, 0))
                F(
                    i[0] + (i[3] // 6) + 1,
                    i[1] + (i[4] // 6) + 1,
                    i[3] - (i[3] // 6) * 2 - 2,
                    i[4] - (i[4] // 6) * 2 - 2,
                    c_carre,
                )

    if booljump:
        # erase head
        fill_rect(x, y - 8 * 2, 12 * 2, 4 * 2, bg)
        fill_rect(x + 8 * 2, y - 7 * 2, 5 * 2, 7 * 2, bg)

        y = y_floor - side - L_saut[compteur_saut]
        compteur_saut += 1

        if compteur_saut == len(L_saut):
            compteur_saut = 0
            booljump = False

        if precedent_y < y:
            F(x - 2, y - 4, side + 4, 4, bg)
        else:
            F(x - 2, y + side, side + 4, precedent_y - y, bg)
    # brick
    F(100, 138, 21, 2, (0, 0, 0))
    F(100, 140, 21, 4, (210, 196, 144))
    F(100, 144, 21, 3, (0, 0, 0))
    F(100, 147, 21, 20, (172, 59, 26))
    F(100, 167, 21, 2, (0, 0, 0))

    display_square()
