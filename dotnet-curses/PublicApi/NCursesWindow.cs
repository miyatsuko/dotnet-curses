using System;
using System.Text;
using Mindmagma.Curses.Interop;

// functions for working with curses windows (including stdscr)

namespace Mindmagma.Curses
{
    public static partial class NCurses
    {
        public static void Box(IntPtr window, char verticalChar, char horizontalChar)
        {
            int result = Native.box(window, verticalChar, horizontalChar);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Box));
        }

        public static void EraseWindow(IntPtr window)
        {
            int result = Native.werase(window);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(EraseWindow));
        }

        public static void ClearWindow(IntPtr window)
        {
            int result = Native.wclear(window);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(ClearWindow));
        }

        public static void CopyWindow(IntPtr sourceWindow, IntPtr destinationWindow, int sourceRow, int sourceColumn, int destinationRow, int destinationColumn, int rowOffset, int columnOffset, bool type)
        {
            int result = Native.copywin(sourceWindow, destinationWindow, sourceRow, sourceColumn, destinationRow, destinationColumn, rowOffset, columnOffset, type);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(CopyWindow));
        }

        public static int DeleteWindow(IntPtr window)
        {
            int result = Native.delwin(window);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(DeleteWindow));
            return result;
        }

        public static IntPtr DeriveWindow(IntPtr window, int rows, int columns, int y, int x)
        {
            IntPtr result = Native.derwin(window, rows, columns, y, x);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(DeriveWindow));
            return result;
        }

        public static IntPtr DuplicateWindow(IntPtr window)
        {
            IntPtr result = Native.dupwin(window);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(DuplicateWindow));
            return result;
        }

        public static void GetBegYX(IntPtr window, out int y, out int x)
        {
            y = Native.getbegy(window);
            NativeExceptionHelper.ThrowOnFailure(y, nameof(GetBegYX));
            x = Native.getbegx(window);
            NativeExceptionHelper.ThrowOnFailure(x, nameof(GetBegYX));
        }

        public static void GetMaxYX(IntPtr window, out int y, out int x)
        {
            y = Native.getmaxy(window);
            NativeExceptionHelper.ThrowOnFailure(y, nameof(GetMaxYX));
            x = Native.getmaxx(window);
            NativeExceptionHelper.ThrowOnFailure(x, nameof(GetMaxYX));
        }

        public static void GetYX(IntPtr window, out int y, out int x)
        {
            y = Native.getcury(window);
            NativeExceptionHelper.ThrowOnFailure(y, nameof(GetYX));
            x = Native.getcurx(window);
            NativeExceptionHelper.ThrowOnFailure(x, nameof(GetYX));
        }

        public static void WindowMove(IntPtr window, int y, int x)
        {
            int result = Native.wmove(window, y, x);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowMove));
        }

        public static void Keypad(IntPtr window, bool enable)
        {
            int result = Native.keypad(window, enable);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Keypad));
        }

        public static int MoveWindowAddString(IntPtr window, int y, int x, string message)
        {
            int result = Native.mvwaddstr(window, y, x, message);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(MoveWindowAddString));
            return result;
        }

        public static int MoveWindowAddNString(IntPtr window, int y, int x, string message, int n)
        {
            int result = Native.mvwaddnstr(window, y, x, message, n);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(MoveWindowAddString));
            return result;
        }

        public static int MoveWindowAddWideString(IntPtr window, int y, int x, string message)
        {
            int result = Native.mvwaddwstr(window, y, x, message);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(MoveWindowAddString));
            return result;
        }

        public static int MoveWindowAddNWideString(IntPtr window, int y, int x, string message, int n)
        {
            int result = Native.mvwaddnwstr(window, y, x, message, n);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(MoveWindowAddString));
            return result;
        }

        public static void MoveWindow(IntPtr window, int row, int column)
        {
            int result = Native.mvwin(window, row, column);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(MoveWindow));
        }

        public static IntPtr NewWindow(int rows, int columns, int yOrigin, int xOrigin)
        {
            IntPtr result = Native.newwin(rows, columns, yOrigin, xOrigin);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(NewWindow));
            return result;
        }

        public static void NoDelay(IntPtr window, bool removeDelay)
        {
            int result = Native.nodelay(window, removeDelay);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(NoDelay));
        }

        public static void Overlay(IntPtr sourceWindow, IntPtr destinationWindow)
        {
            int result = Native.overlay(sourceWindow, destinationWindow);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Overlay));
        }

        public static void Overwrite(IntPtr sourceWindow, IntPtr destinationWindow)
        {
            int result = Native.overwrite(sourceWindow, destinationWindow);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Overwrite));
        }

        public static void Scroll(IntPtr window)
        {
            int result = Native.scroll(window);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(Scroll));
        }

        public static void ScrollOk(IntPtr window, bool canScroll)
        {
            int result = Native.scrollok(window, canScroll);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(ScrollOk));
        }

        public static IntPtr SubWindow(IntPtr parent, int rows, int columns, int y, int x)
        {
            IntPtr result = Native.subwin(parent, rows, columns, y, x);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(SubWindow));
            return result;
        }

        public static void TouchLine(IntPtr window, int row, int column)
        {
            int result = Native.touchline(window, row, column);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(TouchLine));
        }

        public static int TouchWindow(IntPtr window)
        {
            int result = Native.touchwin(window);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(TouchWindow));
            return result;
        }

        public static int WindowAddChar(IntPtr window, int character)
        {
            int result = Native.waddch(window, character);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowAddChar));
            return result;
        }

        public static int WindowAddString(IntPtr window, string message)
        {
            int result = Native.waddstr(window, message);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowAddString));
            return result;
        }

        public static int WindowAddNString(IntPtr window, string message, int n)
        {
            int result = Native.waddnstr(window, message, n);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowAddNString));
            return result;
        }

        public static int WindowAddWideString(IntPtr window, string message)
        {
            int result = Native.waddwstr(window, message);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowAddWideString));
            return result;
        }

        public static int WindowAddNWideString(IntPtr window, string message, int n)
        {
            int result = Native.waddnwstr(window, message, n);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowAddNWideString));
            return result;
        }

        public static int WindowAttributeOff(IntPtr window, uint attribute)
        {
            int result = Native.wattroff(window, attribute);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowAttributeOff));
            return result;
        }

        public static int WindowAttributeOn(IntPtr window, uint attribute)
        {
            int result = Native.wattron(window, attribute);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowAttributeOn));
            return result;
        }

        public static int WindowAttributeSet(IntPtr window, uint attribute)
        {
            int result = Native.wattrset(window, attribute);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowAttributeSet));
            return result;
        }

        public static void WindowBackground(IntPtr window, uint ch)
        {
            int result = Native.wbkgd(window, ch);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowBackground));
        }

        public static void WindowBorder(IntPtr window, char leftSide, char rightSide, char topSide, char bottomSide, char topLeftHandCorner, char topRightHandCorner, char bottomLeftHandCorner, char bottomRightHandCorner)
        {
            int result = Native.wborder(window, leftSide, rightSide, topSide, bottomSide, topLeftHandCorner, topRightHandCorner, bottomLeftHandCorner, bottomRightHandCorner);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowBorder));
        }

        public static int WindowGetChar(IntPtr window)
        {
            int result = Native.wgetch(window);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowGetChar));
            return result;
        }

        public static int MoveWindowGetChar(IntPtr window)
        {
            int result = Native.mvwgetch(window);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(MoveWindowGetChar));
            return result;
        }

        public static int WindowRefresh(IntPtr window)
        {
            int result = Native.wrefresh(window);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowRefresh));
            return result;
        }

        public static int WindowResize(IntPtr window, int lines, int columns)
        {
            int result = Native.wresize(window, lines, columns);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowResize));
            return result;
        }

        public static void WindowScrollLines(IntPtr window, int numberOfLines)
        {
            int result = Native.wscrl(window, numberOfLines);
            NativeExceptionHelper.ThrowOnFailure(result, nameof(WindowScrollLines));
        }
    }
}
