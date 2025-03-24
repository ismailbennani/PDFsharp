// PDFsharp - A .NET library for processing PDF
// See the LICENSE file in the solution root for more information.

// ReSharper disable ConvertToAutoProperty

namespace PdfSharp.Pdf
{
    /// <summary>
    /// Holds information how to handle the document when it is saved as PDF stream.
    /// </summary>
    public sealed class PdfDocumentOptions
    {
        internal PdfDocumentOptions(PdfDocument document)
        {
            //_deflateContents = true;
            //_writeProcedureSets = true;
        }

        /// <summary>
        /// Gets or sets the color mode.
        /// </summary>
        public PdfColorMode ColorMode
        {
            get => _colorMode;
            set => _colorMode = value;
        }
        PdfColorMode _colorMode = PdfColorMode.Rgb;

        /// <summary>
        /// Gets or sets a value indicating whether to compress content streams of PDF pages.
        /// </summary>
        public bool CompressContentStreams
        {
            get => _compressContentStreams;
            set => _compressContentStreams = value;
        }
#if DEBUG
        bool _compressContentStreams = false;
#else
        bool _compressContentStreams = true;
#endif

        /// <summary>
        /// Gets or sets a value indicating that all objects are not compressed.
        /// </summary>
        public bool NoCompression
        {
            get => _noCompression;
            set => _noCompression = value;
        }
        bool _noCompression;

        /// <summary>
        /// Gets or sets the flate encode mode. Besides the balanced default mode you can set modes for best compression (slower) or best speed (larger files).
        /// </summary>
        public PdfFlateEncodeMode FlateEncodeMode
        {
            get => _flateEncodeMode;
            set => _flateEncodeMode = value;
        }
        PdfFlateEncodeMode _flateEncodeMode = PdfFlateEncodeMode.Default;

        /// <summary>
        /// Gets or sets a value indicating whether to compress bilevel images using CCITT compression.
        /// With true, PDFsharp will try FlateDecode CCITT and will use the smallest one or a combination of both.
        /// With false, PDFsharp will always use FlateDecode only - files may be a few bytes larger, but file creation is faster.
        /// </summary>
        public bool EnableCcittCompressionForBilevelImages
        {
            get => _enableCcittCompressionForBilevelImages;
            set => _enableCcittCompressionForBilevelImages = value;
        }
        bool _enableCcittCompressionForBilevelImages = false;

        /// <summary>
        /// Gets or sets a value indicating whether to compress JPEG images with the FlateDecode filter.
        /// </summary>
        public PdfUseFlateDecoderForJpegImages UseFlateDecoderForJpegImages
        {
            get => _useFlateDecoderForJpegImages;
            set => _useFlateDecoderForJpegImages = value;
        }
        PdfUseFlateDecoderForJpegImages _useFlateDecoderForJpegImages = PdfUseFlateDecoderForJpegImages.Never;

        /// <summary>
        /// Indicates whether PDFsharp should automatically generate XMP metadata or if it should be provided manually by the user.
        /// When set to true, PDFsharp will create new metadata and update the catalog reference to point to it, preventing user-created or existing metadata from being used.
        /// Defaults to true.
        /// </summary>
        /// <remarks>
        /// WARNING: If set to false, the user must provide the XMP metadata.
        /// </remarks>
        public bool AutomaticXmpGeneration
        {
            get => _automaticXmpGeneration;
            set => _automaticXmpGeneration = value;
        }
        bool _automaticXmpGeneration = false;
    }
}
