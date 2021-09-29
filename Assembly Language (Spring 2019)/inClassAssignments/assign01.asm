; Justin Heyman
; CSCI 273-6724
; Wed, 2/20/2019
;
; Type in the following code as a .asm file.
; Assemble and link the file to ensure there are no errors.
; Also comment the code to indicate what each line is doing.

section .data ; Section used for storing initialized variables.

decimalLiteral: db 31 ; Reserves 1 byte to stores 31d.
hexLiteral: dd 0Fh ; Reserves a 4 byte space to store 0fh.
charLiteral: db 'A' ; Reserves 1 byte to store char 'A'.

stringLiteral: ; Declaration of a variable
 db "This is a string that", 0ah ; Reserves 1 byte to store the string appended by the ASCII linefeed'\n'.
 db "has a line break in it.",0 ; Reserves 1 byte to store the string and 0 ends the string.

section .bss ; Section used for storing uninitialized variables.

unInitVariable: resd 1 ; Creates a pointer to a 4 byte memory space

section .text ; Section used for the main program, lines here are READ ONLY for the executable program.
global _main ; Creates the label "_main".

_main: ; Identifies program entry for the linker.

partOne: ; Creates label for the two instructions below. The instructions below are not local members though.
mov eax, 10 ; Moves 10d into the eax register
add eax, hexLiteral ; Adds 0fh to 10d in the eax register, storing the result in eax.

partTwo: ; Label
inc eax ; Increments the value in eax by 1.

; These last three lines close the program properly.
mov eax, 1
mov ebx, 0
int 80h ; 
