#pragma once
#include <iostream>
#include <fstream>
#include <string.h>
#include <stdlib.h>
#define ROWS 15
#define COLS 15

using namespace std;

bool getGameBoard(int iGameBoard[ROWS][COLS])
{
	int iCur;
	char cInput;
	ifstream in("boardstate.txt");

	for (iCur = 0; iCur < ROWS * COLS; iCur++)
	{
		cInput = in.get();
		switch (cInput)
		{
		case '\n':
		case '\t':
			iCur--;
			break;
		case 'A':
		case 'a':
			iGameBoard[iCur / COLS][iCur % COLS] = -1;
			break;
		case 'B':
		case 'b':
			iGameBoard[iCur / COLS][iCur % COLS] = 6;
			break;
		case 'M':
		case 'm':
			iGameBoard[iCur / COLS][iCur % COLS] = 5;
			break;
		case '1':
			iGameBoard[iCur / COLS][iCur % COLS] = 1;
			break;
		case '2':
			iGameBoard[iCur / COLS][iCur % COLS] = 2;
			break;
		case '3':
			iGameBoard[iCur / COLS][iCur % COLS] = 3;
			break;
		case '_':
			iGameBoard[iCur / COLS][iCur % COLS] = 0;
			break;
		default:
			in.close();
			return false;
		}
	}
	in.close();
	return true;
}

bool putMove(int iMoveRow, int iMoveCol)
{
	ofstream out("move.txt");

	if (iMoveCol >= COLS || iMoveCol < 0)
		return false;
	if (iMoveRow >= ROWS || iMoveRow < 0)
		return false;
	out << iMoveRow << " " << iMoveCol << endl;
	out.close();
	return true;
}