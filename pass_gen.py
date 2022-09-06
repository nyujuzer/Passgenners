from random import randint, random
import secrets

abc = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z']
ABC = ['A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z']
nums = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9]
specs = ["!","@","{","}","?"]
length = int(input(">>>"))
placehold = "your password is "
blank = ""

def password(length, abc, ABC, nums, placehold, blank):
    pass_let = []
    for i in range(length):
        type = randint(1, 5)

        if type == 1:
            specials = secrets.choice(specs)
            pass_let.append(specials)
        if type > 2 < 3:
            letters = secrets.choice(abc)
            pass_let.append(letters)
        if type == 4:
            caps = secrets.choice(ABC)
            pass_let.append(caps)
        if type == 5:
            nbrs = str(secrets.choice(nums))
            pass_let.append(nbrs)
    for x in pass_let:
        blank += x


    print(placehold + blank)

password(length, abc, ABC, nums, placehold, blank)

input("")
