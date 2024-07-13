Game Sudoku:
- Đây là dự án phát triển game Sudoku bằng ngôn ngữ C# và .NET, sử dụng thuật toán Backtracking để giải quyết và tạo các bảng Sudoku.

Giới Thiệu:
- Sudoku là một trò chơi giải đố với lưới 9x9, chia thành 9 vùng 3x3, trong đó một số ô đã được điền sẵn các con số từ 1 đến 9. Nhiệm vụ của người chơi là điền các con số vào các ô trống sao cho mỗi hàng, mỗi cột và mỗi vùng 3x3 đều chứa đủ các số từ 1 đến 9 mà không trùng lặp.

Các Tính Năng Chính:
- Tạo bảng Sudoku: Tạo các bảng Sudoku ngẫu nhiên với độ khó khác nhau.
- Giải quyết Sudoku: Sử dụng thuật toán Backtracking để giải quyết các bảng Sudoku đã cho.
- Giao diện người dùng: Giao diện người dùng thân thiện, cho phép người chơi nhập và xóa các con số.
- Kiểm tra lỗi: Kiểm tra và thông báo lỗi khi người chơi nhập số không hợp lệ.
- Kết quả: Hiển thị kết quả, độ khó và thời gian hoàn thành trò chơi.

Thuật Toán Backtracking:
1.Thuật toán Backtracking là một phương pháp giải quyết vấn đề bằng cách thử các lựa chọn và quay lại nếu gặp phải ngõ cụt. Trong game Sudoku, thuật toán này sẽ:
2.Tìm ô trống: Tìm ô trống đầu tiên trong bảng Sudoku.
3.Thử các con số: Thử các con số từ 1 đến 9 vào ô trống.
4.Kiểm tra hợp lệ: Kiểm tra xem số đã điền có hợp lệ không (không trùng lặp trong hàng, cột và vùng 3x3).
5.Tiếp tục: Nếu số hợp lệ, tiếp tục với ô trống tiếp theo; nếu không, thử số khác.
6.Quay lui: Nếu không có số nào hợp lệ, quay lại ô trước đó và thử số khác.
