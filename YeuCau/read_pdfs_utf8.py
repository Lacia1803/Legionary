import pypdf
import os

pdf_files = [
    "01-THONG-BAO-CUOI-KY.pdf",
    "02-DE-CUONG-CUOI-KY.pdf",
    "07-TEMPLATE-BAO-CAO.pdf"
]

with open("output_utf8.txt", "w", encoding="utf-8") as f:
    for pdf_file in pdf_files:
        f.write(f"=== {pdf_file} ===\n")
        try:
            reader = pypdf.PdfReader(pdf_file)
            text = ""
            for page in reader.pages:
                text += page.extract_text() + "\n"
            f.write(text)
        except Exception as e:
            f.write(f"Error reading {pdf_file}: {e}\n")
        f.write("=" * 40 + "\n\n")
