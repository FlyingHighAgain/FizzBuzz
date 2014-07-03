; fizzbuzz.scm

(for-each print
  (map
    (lambda (x)
      (cond
        ((and 
          (= (modulo x 3) 0)
          (= (modulo x 5) 0)) "FizzBuzz")
        ((= (modulo x 3) 0)   "Fizz")
        ((= (modulo x 5) 0)   "Buzz")
        (else x)))
    (iota 100 1)))

