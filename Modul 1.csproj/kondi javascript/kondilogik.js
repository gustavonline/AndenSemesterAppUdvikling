function BeregnKondiTal(dist, isMale) {
    if (isMale == true) {
        return 18.38 + (0.03301 * dist) - (5.92 * 1)
    }
    else {
        return 18.38 + (0.03301 * dist) - (5.92 * 0)
    }
 };

 