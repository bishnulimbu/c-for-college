def factorize(n):
    d = 2
    while d * d <= n:
        if n % d == 0:
            yield d
            n //= d
        else:
            d += 1
    if n > 1:
        yield n
