from multiprocessing import Pool
from numpy import real, imag, abs
from PIL import Image
from threading import Thread
import os

resolution = 15000  # not direct resolution, but proportional to it
resolution100 = int(resolution * 0.01)
size = tuple([100, resolution * 2])
color = tuple([1])
start_r = 0
stop_r = 0
"""r is real and i is imaginary where practical"""


def process_job(r):
    """creates a slice of the set"""
    img = Image.new("1", size, color)  # B&W image
    print(int(r + 2 * resolution100 + 1), "of", int(resolution100 * 3))
    r = r * 100
    for rval in range(100):
        for i in range(-resolution, resolution, 1):
            if abrot(((r + rval) / resolution), (i / resolution * 1j)):
                try:
                    img.putpixel(
                        (
                            rval,
                            i + resolution,
                        ),
                        0,
                    )
                except:
                    print(r, rval, i + resolution)
    img.save(
        (
            "z_images/"
            + str(resolution)
            + "/"
            + str(int(r / 100) + int(resolution * 0.02))
            + ".png"
        )
    )


def abrot(x, y):
    """tests a point"""
    c = x + y
    z = 0 + 0j
    for _ in range(5):
        z = z * z + c
    if abs(real(z * z + c)) >= 2 and abs(imag(z * z + c)) >= 2:
        return False
    for _ in range(int(resolution / 10)):
        if real(z + 0.0001) > float(real(z * z + c)) > real(z - 0.0001):
            return True
        z = z * z + c
        if abs(real(z)) >= 2:
            return False
    return True


def doItAll(resolution):
    with Pool(4, maxtasksperchild=10) as p:
        p.map(
            process_job,
            range((-2 * resolution100 + start_r), resolution100 - stop_r, 1),
        )


if __name__ == "__main__":
    try:
        os.mkdir(
            "/Users/milo/PycharmProjects/mandlebrot/venv/z_images/"
            + str(resolution)
            + "/"
        )  # I know I misspelled it
    except:
        pass
    doItAll(resolution)
    # image names must be sorted, but are strings like '1.png', so dict is used
    beta_dirs = os.listdir(
        "/Users/milo/PycharmProjects/mandlebrot/venv/z_images/" + str(resolution) + "/"
    )
    dic = {}
    for dir in beta_dirs:
        key = ""
        for character in dir:
            if character in "1234567890-":
                key += character
        dic[int(key)] = dir
    img = Image.new("1", (resolution * 3, resolution * 2))
    r_offset = 0
    for dir in sorted(dic.items()):
        im = Image.open(
            "/Users/milo/PycharmProjects/mandlebrot/venv/z_images/"
            + str(resolution)
            + "/"
            + dir[1]
        )
        img.paste(im, (r_offset, 0))
        r_offset += 100
    img.save(("z_images/brot" + str(resolution) + ".png"))
    print("saved as brot" + str(resolution) + ".png")
