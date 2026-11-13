namespace TradingDataEngine.DataTypes;

public record CandlePatterns
(
    // Doji: open and close are equal or nearly equal
    bool Doji = false,              // Open ≈ close, any shadow lengths
    bool LongLegDoji = false,       // Open ≈ close, long upper and lower shadows
    bool Dragonfly = false,         // Open ≈ close, near the high, long lower shadow, no upper shadow (bullish)
    bool Gravestone = false,        // Open ≈ close, near the low, long upper shadow, no lower shadow (bearish)
    bool SpinTop = false,           // Small body with shadows on both sides

    // Hammer family: small body with a long shadow
    bool Hammer = false,            // Small body at the top, long lower shadow, after a downtrend (bullish)
    bool HangingMan = false,        // Same shape as Hammer, after an uptrend (bearish)
    bool InvHammer = false,         // Small body at the bottom, long upper shadow, after a downtrend (bullish)
    bool ShootingStar = false,      // Same shape as InvHammer, after an uptrend (bearish)

    // Marubozu: long body with no shadows on one or both sides
    bool BullMaru = false,          // Bullish candle with no shadows
    bool BearMaru = false,          // Bearish candle with no shadows
    bool BullOpenMaru = false,      // Bullish, opens at the low (no lower shadow)
    bool BearOpenMaru = false,      // Bearish, opens at the high (no upper shadow)
    bool BullCloseMaru = false,     // Bullish, closes at the high (no upper shadow)
    bool BearCloseMaru = false,     // Bearish, closes at the low (no lower shadow)

    // Belt Hold: long body, opens at one extreme with no shadow on that side
    bool BullBelt = false,          // Bullish belt hold: opens at the low, no lower shadow
    bool BearBelt = false,          // Bearish belt hold: opens at the high, no upper shadow

    // Single-candle shapes
    bool HighWave = false,          // Small body with very long shadows on both sides
    bool Takuri = false,            // Dragonfly-like with a very long lower shadow
    bool LongLine = false,          // Long real body
    bool ShortLine = false,         // Short real body

    // Engulfing: current body fully engulfs the previous body
    bool BullEngulf = false,        // Bullish body engulfs the prior bearish body (bullish reversal)
    bool BearEngulf = false,        // Bearish body engulfs the prior bullish body (bearish reversal)

    // Harami: current body is inside the previous body
    bool BullHarami = false,        // Small bullish body inside the prior long bearish body
    bool BearHarami = false,        // Small bearish body inside the prior long bullish body
    bool BullHaramiX = false,       // Bullish harami where the inside candle is a doji
    bool BearHaramiX = false,       // Bearish harami where the inside candle is a doji

    // Two-candle reversal and continuation patterns
    bool Piercing = false,          // Bullish: opens below prior low, closes above prior body midpoint
    bool DarkCloud = false,         // Bearish: opens above prior high, closes below prior body midpoint
    bool TweezerBottom = false,     // Matching lows after a downtrend (bullish)
    bool TweezerTop = false,        // Matching highs after an uptrend (bearish)
    bool BullKick = false,          // Bearish marubozu, then bullish marubozu gapping up
    bool BearKick = false,          // Bullish marubozu, then bearish marubozu gapping down
    bool BullSepLines = false,      // Bearish then bullish candle with the same open (bullish continuation)
    bool BearSepLines = false,      // Bullish then bearish candle with the same open (bearish continuation)
    bool BullCounter = false,       // Long bearish candle, then bullish candle closing at the same close (bullish reversal)
    bool BearCounter = false,       // Long bullish candle, then bearish candle closing at the same close (bearish reversal)
    bool HomingPigeon = false,      // Two bearish candles, second body inside the first (bullish reversal)
    bool MatchingLow = false,       // Bearish candle, then bearish candle closing at the same low (bullish reversal)
    bool OnNeck = false,            // Bearish, then bullish candle closing at the prior low (bearish continuation)
    bool InNeck = false,            // Bearish, then bullish candle closing slightly above the prior close (bearish continuation)
    bool Thrusting = false,         // Bearish, then bullish candle closing into the prior body but below its midpoint (bearish continuation)

    // Three-candle reversal patterns
    bool MorningStar = false,       // Long bearish, small body, long bullish (bullish reversal)
    bool EveningStar = false,       // Long bullish, small body, long bearish (bearish reversal)
    bool MornDojiStar = false,      // Morning star where the middle candle is a doji
    bool EveDojiStar = false,       // Evening star where the middle candle is a doji
    bool BullAbandoned = false,     // Bullish abandoned baby: doji gapped away from both neighbors (bullish reversal)
    bool BearAbandoned = false,     // Bearish abandoned baby: doji gapped away from both neighbors (bearish reversal)

    // Three-candle continuation and confirmation patterns
    bool ThreeSoldiers = false,     // Three long bullish candles, each closing higher (bullish)
    bool ThreeCrows = false,        // Three long bearish candles, each closing lower (bearish)
    bool ThreeInUp = false,         // Bearish candle, bullish harami, then bullish close above the first open
    bool ThreeInDown = false,       // Bullish candle, bearish harami, then bearish close below the first open
    bool ThreeOutUp = false,        // Bullish engulfing, then a higher bullish close (bullish)
    bool ThreeOutDown = false,      // Bearish engulfing, then a lower bearish close (bearish)
    bool BullTriStar = false,       // Three dojis, middle one gapped down (bullish reversal)
    bool BearTriStar = false,       // Three dojis, middle one gapped up (bearish reversal)

    // Gap patterns
    bool UpTasukiGap = false,       // Upward gap continuation: black candle opens in the body and closes into the gap (bullish)
    bool DownTasukiGap = false,     // Downward gap continuation: white candle opens in the body and closes into the gap (bearish)
    bool UpGapTwoCrows = false,     // Bullish candle, gap up black candle, then a black candle engulfing it (bearish reversal)
    bool ThreeStarsSouth = false,   // Three declining bearish candles with long lower shadows and shrinking range (bullish reversal)
    bool UniqueRiver = false,       // Downtrend with a long bearish candle, a hammer-like low, then a small bullish candle (bullish reversal)
    bool TwoCrows = false,          // Long bullish candle, gap up black candle, then a black candle closing into the first body (bearish reversal)
    bool IdenticalCrows = false,    // Three bearish candles, each opening at the prior close (bearish reversal)
    bool Advance = false,           // Advance Block: three bullish candles with shrinking bodies and long upper shadows (bearish reversal)
    bool Stalled = false,           // Stalled pattern: three bullish candles, third one small and stalling near the second (bearish reversal)
    bool BullStickSandwich = false, // Bearish, bullish, then bearish closing at the first close (bullish reversal)
    bool UpThreeMethods = false,    // Long bullish candle, three small bearish candles inside it, then a bullish close above the first high (bullish continuation)
    bool DownThreeMethods = false,  // Long bearish candle, three small bullish candles inside it, then a bearish close below the first low (bearish continuation)
    bool UpSideBySide = false,      // Upward gap, then two bullish candles with similar opens (bullish continuation)
    bool DownSideBySide = false,    // Downward gap, then two bearish candles with similar opens (bearish continuation)

    // Hikkake: inside bar breakout that fails and reverses
    bool BullHikkake = false,       // Bullish hikkake
    bool BearHikkake = false        // Bearish hikkake
);
