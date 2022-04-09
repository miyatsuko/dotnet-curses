using System;
using System.Runtime.InteropServices;
using System.Text;

#pragma warning disable IDE1006 // naming rule violation, methods must begin with uppercase

// functions for working with curses windows

namespace Mindmagma.Curses.Interop
{
    internal static partial class Native
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_box(IntPtr window, char verticalChar, char horizontalChar);
        private static dt_box call_box = NativeToDelegate<dt_box>("box");
        internal static int box(IntPtr window, char verticalChar, char horizontalChar) => call_box(window, verticalChar, horizontalChar);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_copywin(IntPtr sourceWindow, IntPtr destinationWindow, int sourceRow, int sourceColumn, int destinationRow, int destinationColumn, int rowOffset, int columnOffset, bool type);
        private static dt_copywin call_copywin = NativeToDelegate<dt_copywin>("copywin");
        internal static int copywin(IntPtr sourceWindow, IntPtr destinationWindow, int sourceRow, int sourceColumn, int destinationRow, int destinationColumn, int rowOffset, int columnOffset, bool type)
            => call_copywin(sourceWindow, destinationWindow, sourceRow, sourceColumn, destinationRow, destinationColumn, rowOffset, columnOffset, type);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_delwin(IntPtr window);
        private static dt_delwin call_delwin = NativeToDelegate<dt_delwin>("delwin");
        internal static int delwin(IntPtr window) => call_delwin(window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr dt_derwin(IntPtr window, int rows, int columns, int y, int x);
        private static dt_derwin call_derwin = NativeToDelegate<dt_derwin>("derwin");
        internal static IntPtr derwin(IntPtr window, int rows, int columns, int y, int x) => call_derwin(window, rows, columns, y, x);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr dt_dupwin(IntPtr window);
        private static dt_dupwin call_dupwin = NativeToDelegate<dt_dupwin>("dupwin");
        internal static IntPtr dupwin(IntPtr window) => call_dupwin(window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_getcurx(IntPtr window);
        private static dt_getcurx call_getcurx = NativeToDelegate<dt_getcurx>("getcurx");
        internal static int getcurx(IntPtr window) => call_getcurx(window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_getcury(IntPtr window);
        private static dt_getcury call_getcury = NativeToDelegate<dt_getcury>("getcury");
        internal static int getcury(IntPtr window) => call_getcury(window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_getbegx(IntPtr window);
        private static dt_getbegx call_getbegx = NativeToDelegate<dt_getbegx>("getbegx");
        internal static int getbegx(IntPtr window) => call_getbegx(window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_getbegy(IntPtr window);
        private static dt_getbegy call_getbegy = NativeToDelegate<dt_getbegy>("getbegy");
        internal static int getbegy(IntPtr window) => call_getbegy(window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_getmaxx(IntPtr window);
        private static dt_getmaxx call_getmaxx = NativeToDelegate<dt_getmaxx>("getmaxx");
        internal static int getmaxx(IntPtr window) => call_getmaxx(window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_getmaxy(IntPtr window);
        private static dt_getmaxy call_getmaxy = NativeToDelegate<dt_getmaxy>("getmaxy");
        internal static int getmaxy(IntPtr window) => call_getmaxy(window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_wmove(IntPtr window, int y, int x);
        private static dt_wmove call_wmove = NativeToDelegate<dt_wmove>("wmove");
        internal static int wmove(IntPtr window, int y, int x) => call_wmove(window, y, x);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_keypad(IntPtr window, bool enable);
        private static dt_keypad call_keypad = NativeToDelegate<dt_keypad>("keypad");
        internal static int keypad(IntPtr window, bool enable) => call_keypad(window, enable);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int dt_mvwaddstr(IntPtr window, int y, int x, string message);
        private static dt_mvwaddstr call_mvwaddstr = NativeToDelegate<dt_mvwaddstr>("mvwaddstr");
        internal static int mvwaddstr(IntPtr window, int y, int x, string message) => call_mvwaddstr(window, y, x, message);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int dt_mvwaddnstr(IntPtr window, int y, int x, string message, int n);
        private static dt_mvwaddnstr call_mvwaddnstr = NativeToDelegate<dt_mvwaddnstr>("mvwaddnstr");
        internal static int mvwaddnstr(IntPtr window, int y, int x, string message, int n) => call_mvwaddnstr(window, y, x, message, n);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_mvwaddwstr(IntPtr window, int y, int x, byte[] message);
        private static dt_mvwaddwstr call_mvwaddwstr = NativeToDelegate<dt_mvwaddwstr>("mvwaddwstr");
        internal static int mvwaddwstr(IntPtr window, int y, int x, string message) => call_mvwaddwstr(window, y, x, Encoding.UTF32.GetBytes(message));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_mvwaddnwstr(IntPtr window, int y, int x, byte[] message, int n);
        private static dt_mvwaddnwstr call_mvwaddnwstr = NativeToDelegate<dt_mvwaddnwstr>("mvwaddnwstr");
        internal static int mvwaddnwstr(IntPtr window, int y, int x, string message, int n) => call_mvwaddnwstr(window, y, x, Encoding.UTF32.GetBytes(message), n);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_mvwin(IntPtr window, int row, int column);
        private static dt_mvwin call_mvwin = NativeToDelegate<dt_mvwin>("mvwin");
        internal static int mvwin(IntPtr window, int row, int column) => call_mvwin(window, row, column);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr dt_newwin(int rows, int columns, int yOrigin, int xOrigin);
        private static dt_newwin call_newwin = NativeToDelegate<dt_newwin>("newwin");
        internal static IntPtr newwin(int rows, int columns, int yOrigin, int xOrigin) => call_newwin(rows, columns, yOrigin, xOrigin);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_nodelay(IntPtr window, bool removeDelay);
        private static dt_nodelay call_nodelay = NativeToDelegate<dt_nodelay>("nodelay");
        internal static int nodelay(IntPtr window, bool removeDelay) => call_nodelay(window, removeDelay);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_overlay(IntPtr sourceWindow, IntPtr destinationWindow);
        private static dt_overlay call_overlay = NativeToDelegate<dt_overlay>("overlay");
        internal static int overlay(IntPtr sourceWindow, IntPtr destinationWindow) => call_overlay(sourceWindow, destinationWindow);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_overwrite(IntPtr sourceWindow, IntPtr destinationWindow);
        private static dt_overwrite call_overwrite = NativeToDelegate<dt_overwrite>("overwrite");
        internal static int overwrite(IntPtr sourceWindow, IntPtr destinationWindow) => call_overwrite(sourceWindow, destinationWindow);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_scrl(int numberOfLines);
        private static dt_scrl call_scrl = NativeToDelegate<dt_scrl>("scrl");
        internal static int scrl(int numberOfLines) => call_scrl(numberOfLines);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_scroll(IntPtr window);
        private static dt_scroll call_scroll = NativeToDelegate<dt_scroll>("scroll");
        internal static int scroll(IntPtr window) => call_scroll(window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate IntPtr dt_subwin(IntPtr window, int rows, int colums, int y, int x);
        private static dt_subwin call_subwin = NativeToDelegate<dt_subwin>("subwin");
        internal static IntPtr subwin(IntPtr window, int rows, int colums, int y, int x) => call_subwin(window, rows, colums, y, x);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_touchline(IntPtr window, int row, int column);
        private static dt_touchline call_touchline = NativeToDelegate<dt_touchline>("touchline");
        internal static int touchline(IntPtr window, int row, int column) => call_touchline(window, row, column);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_touchwin(IntPtr window);
        private static dt_touchwin call_touchwin = NativeToDelegate<dt_touchwin>("touchwin");
        internal static int touchwin(IntPtr window) => call_touchwin(window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_waddch(IntPtr window, int character);
        private static dt_waddch call_waddch = NativeToDelegate<dt_waddch>("waddch");
        internal static int waddch(IntPtr window, int character) => call_waddch(window, character);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int dt_waddstr(IntPtr window, string message);
        private static dt_waddstr call_waddstr = NativeToDelegate<dt_waddstr>("waddstr");
        internal static int waddstr(IntPtr window, string message) => call_waddstr(window, message);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int dt_waddnstr(IntPtr win, String str, int n);
        private static dt_waddnstr call_waddnstr = NativeToDelegate<dt_waddnstr>("waddnstr");
        internal static int waddnstr(IntPtr win, String str, int n) => call_waddnstr(win, str, n);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_waddwstr(IntPtr window, byte[] message);
        private static dt_waddwstr call_waddwstr = NativeToDelegate<dt_waddwstr>("waddwstr");
        internal static int waddwstr(IntPtr window, string message) => call_waddwstr(window, Encoding.UTF32.GetBytes(message));

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_waddnwstr(IntPtr window, byte[] message, int n);
        private static dt_waddnwstr call_waddnwstr = NativeToDelegate<dt_waddnwstr>("waddnwstr");
        internal static int waddnwstr(IntPtr window, string message, int n) => call_waddnwstr(window, Encoding.UTF32.GetBytes(message), n);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int dt_wattroff(IntPtr win, uint attributes);
        private static dt_wattroff call_wattroff = NativeToDelegate<dt_wattroff>("wattroff");
        internal static int wattroff(IntPtr win, uint attributes) => call_wattroff(win, attributes);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int dt_wattron(IntPtr win, uint attributes);
        private static dt_wattron call_wattron = NativeToDelegate<dt_wattron>("wattron");
        internal static int wattron(IntPtr win, uint attributes) => call_wattron(win, attributes);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private delegate int dt_wattrset(IntPtr win, uint attributes);
        private static dt_wattrset call_wattrset = NativeToDelegate<dt_wattrset>("wattrset");
        internal static int wattrset(IntPtr win, uint attributes) => call_wattrset(win, attributes);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_wbkgd(IntPtr window, uint ch);
        private static dt_wbkgd call_wbkgd = NativeToDelegate<dt_wbkgd>("wbkgd");
        internal static int wbkgd(IntPtr window, uint ch) => call_wbkgd(window, ch);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_wborder(IntPtr window, char leftSide, char rightSide, char topSide, char bottomSide, char topLeftHandCorner, char topRightHandCorner, char bottomLeftHandCorner, char bottomRightHandCorner);
        private static dt_wborder call_wborder = NativeToDelegate<dt_wborder>("wborder");
        internal static int wborder(IntPtr window, char leftSide, char rightSide, char topSide, char bottomSide, char topLeftHandCorner, char topRightHandCorner, char bottomLeftHandCorner, char bottomRightHandCorner)
            => call_wborder(window, leftSide, rightSide, topSide, bottomSide, topLeftHandCorner, topRightHandCorner, bottomLeftHandCorner, bottomRightHandCorner);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_werase(IntPtr window);
        private static dt_werase call_werase = NativeToDelegate<dt_werase>("werase");
        internal static int werase(IntPtr window) => call_werase(window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_wclear(IntPtr window);
        private static dt_wclear call_wclear = NativeToDelegate<dt_wclear>("wclear");
        internal static int wclear(IntPtr window) => call_wclear(window);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_wgetch(IntPtr win);
        private static dt_wgetch call_wgetch = NativeToDelegate<dt_wgetch>("wgetch");
        internal static int wgetch(IntPtr win) => call_wgetch(win);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_mvwgetch(IntPtr win);
        private static dt_mvwgetch call_mvwgetch = NativeToDelegate<dt_mvwgetch>("mvwgetch");
        internal static int mvwgetch(IntPtr win) => call_mvwgetch(win);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_wrefresh(IntPtr win);
        private static dt_wrefresh call_wrefresh = NativeToDelegate<dt_wrefresh>("wrefresh");
        internal static int wrefresh(IntPtr win) => call_wrefresh(win);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_wresize(IntPtr win, int lines, int columns);
        private static dt_wresize call_wresize = NativeToDelegate<dt_wresize>("wresize");
        internal static int wresize(IntPtr win, int lines, int columns) => call_wresize(win, lines, columns);

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        private delegate int dt_wscrl(IntPtr window, int numberOfLines);
        private static dt_wscrl call_wscrl = NativeToDelegate<dt_wscrl>("wscrl");
        internal static int wscrl(IntPtr window, int numberOfLines) => call_wscrl(window, numberOfLines);
    }
}
